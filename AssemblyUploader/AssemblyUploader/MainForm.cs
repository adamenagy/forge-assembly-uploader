using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Forge;
using Autodesk.Forge.Model;
using RestSharp;

namespace AssemblyUploader
{
  public partial class MainForm : Form
  {
    string accessToken = null;
    string jsonPath = null;

    public MainForm()
    {
      InitializeComponent();
    }

    public string ToBase64(string input)
    {
      var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(input);
      return System.Convert.ToBase64String(plainTextBytes).Replace("=", "");
    }

    private void showFileDialog_Click(object sender, EventArgs e)
    {
      var dlg = new OpenFileDialog();
      if (dlg.ShowDialog() == DialogResult.OK)
      {
        var fileInfo = new FileInfo(dlg.FileName);
        var assemblyPath = fileInfo.FullName;
        jsonPath = Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".json");

        if (!File.Exists(jsonPath))
        {
          MessageBox.Show("Reference info file (" + jsonPath + ") does not exist!", "Error");
          return;
        }

        filePath.Text = assemblyPath;
        uploadFiles.Enabled = true;
      }
    }

    async private Task logIn()
    {
      if (accessToken == null)
      {
        var oAuth = new TwoLeggedApi();
        dynamic resp = await oAuth.AuthenticateAsync(
          clientId.Text, clientSecret.Text,
          "client_credentials",
          new Scope[] { Scope.DataCreate, Scope.DataRead, Scope.DataWrite, Scope.BucketRead, Scope.BucketUpdate });
        accessToken = resp.access_token;
      }
    }

    async private void uploadFiles_Click(object sender, EventArgs e)
    {
      try
      {
        await logIn();

        var objectsApi = new ObjectsApi();
        objectsApi.Configuration.AccessToken = accessToken;
        var fileInfo = new FileInfo(filePath.Text);
        string[] files = Directory.GetFiles(fileInfo.DirectoryName, "*", SearchOption.AllDirectories);
        progressBar.Value = 0;
        var counter = 0;
        foreach (var file in files)
        {
          Debug.WriteLine("Uploading " + file);
          fileInfo = new FileInfo(file);
          using (StreamReader fileStream = new StreamReader(file))
          {
            var newObject = await objectsApi.UploadObjectAsync(bucketName.Text, fileInfo.Name,
                (int)fileStream.BaseStream.Length, fileStream.BaseStream,
                "application/octet-stream");
          }
          progressBar.Value = (int)Math.Floor(counter / files.Length * 100.0);
        }
        progressBar.Value = 100;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    async private Task postReferences()
    {
      var client = new RestClient("https://developer.api.autodesk.com");

      var fileInfo = new FileInfo(filePath.Text);
      var assemblyPath = fileInfo.FullName;
      jsonPath = Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".json");
      string objectIdBase64 = ToBase64("urn:adsk.objects:os.object:" + bucketName.Text + "/" + fileInfo.Name);

      var request = new RestRequest("/modelderivative/v2/designdata/{id}/references", Method.POST);
      request.AddUrlSegment("id", objectIdBase64); // replaces matching token in request.Resource

      request.AddHeader("Authorization", "Bearer " + accessToken);
      request.RequestFormat = DataFormat.Json;

      using (var reader = new StreamReader(jsonPath))
      {
        string json = reader.ReadToEnd();
        json = json.Replace("{bucketName}", bucketName.Text);
        request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
      }

      IRestResponse response = client.Execute(request);
      var content = response.Content;

      MessageBox.Show(content, "Info - Reference Setting");
    }

    async private Task postTranslate()
    {
      var client = new RestClient("https://developer.api.autodesk.com");

      var fileInfo = new FileInfo(filePath.Text);
      var assemblyPath = fileInfo.FullName;
      jsonPath = Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".json");
      string objectIdBase64 = ToBase64("urn:adsk.objects:os.object:" + bucketName.Text + "/" + fileInfo.Name);

      var request = new RestRequest("/modelderivative/v2/designdata/job", Method.POST);

      request.AddHeader("Authorization", "Bearer " + accessToken);
      request.AddHeader("x-ads-force", "true");
      request.RequestFormat = DataFormat.Json;

      using (var reader = new StreamReader("postJobBody.json"))
      {
        string json = reader.ReadToEnd();
        json = json.Replace("{urn}", objectIdBase64);
        request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
      }

      IRestResponse response = client.Execute(request);
      var content = response.Content;

      MessageBox.Show(content, "Info - Translation");
    }

    async private void translateAssembly_Click(object sender, EventArgs e)
    {
      try
      {
        await logIn();

        await postReferences();

        var fileInfo = new FileInfo(filePath.Text);
        string objectIdBase64 = ToBase64("urn:adsk.objects:os.object:" + bucketName.Text + "/" + fileInfo.Name);
        /*
        List<JobPayloadItem> postTranslationOutput = new List<JobPayloadItem>()
        {
          new JobPayloadItem(
          JobPayloadItem.TypeEnum.Svf,
          new List<JobPayloadItem.ViewsEnum>()
          {
             JobPayloadItem.ViewsEnum._3d,
             JobPayloadItem.ViewsEnum._2d
          })
        };
        JobPayload postTranslation = new JobPayload(
            new JobPayloadInput(objectIdBase64),
            new JobPayloadOutput(postTranslationOutput));
        */

        DerivativesApi derivativeApi = new DerivativesApi();
        derivativeApi.Configuration.AccessToken = accessToken;
        //dynamic translation = await derivativeApi.TranslateAsync(postTranslation);
        await postTranslate();

        // check if is ready
        progressBar.Value = 0;
        do
        {
          System.Threading.Thread.Sleep(1000); // wait 1 second
          try
          {
            dynamic manifest = await derivativeApi.GetManifestAsync(objectIdBase64);
            progressBar.Value = (string.IsNullOrWhiteSpace(Regex.Match(manifest.progress, @"\d+").Value) ? 100 : Int32.Parse(Regex.Match(manifest.progress, @"\d+").Value));
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, "Error");
          }
        } while (progressBar.Value < 100);

        MessageBox.Show("Done", "Info - Translation");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }
  }
}
