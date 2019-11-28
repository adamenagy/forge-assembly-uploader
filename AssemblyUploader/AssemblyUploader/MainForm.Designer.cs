namespace AssemblyUploader
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.filePath = new System.Windows.Forms.TextBox();
      this.showFileDialog = new System.Windows.Forms.Button();
      this.uploadFiles = new System.Windows.Forms.Button();
      this.clientId = new System.Windows.Forms.TextBox();
      this.clientSecret = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.bucketName = new System.Windows.Forms.TextBox();
      this.translateAssembly = new System.Windows.Forms.Button();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.tableLayoutPanel1.Controls.Add(this.filePath, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.showFileDialog, 2, 5);
      this.tableLayoutPanel1.Controls.Add(this.uploadFiles, 0, 6);
      this.tableLayoutPanel1.Controls.Add(this.clientId, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.clientSecret, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.bucketName, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.translateAssembly, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 7);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7);
      this.tableLayoutPanel1.RowCount = 9;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 253);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // filePath
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.filePath, 2);
      this.filePath.Dock = System.Windows.Forms.DockStyle.Fill;
      this.filePath.Location = new System.Drawing.Point(10, 160);
      this.filePath.Name = "filePath";
      this.filePath.Size = new System.Drawing.Size(418, 20);
      this.filePath.TabIndex = 0;
      this.filePath.Text = "C:\\Temp\\BoxAssembly\\Boxes.iam";
      // 
      // showFileDialog
      // 
      this.showFileDialog.Location = new System.Drawing.Point(434, 160);
      this.showFileDialog.Name = "showFileDialog";
      this.showFileDialog.Size = new System.Drawing.Size(25, 21);
      this.showFileDialog.TabIndex = 1;
      this.showFileDialog.Text = "...";
      this.showFileDialog.UseVisualStyleBackColor = true;
      this.showFileDialog.Click += new System.EventHandler(this.showFileDialog_Click);
      // 
      // uploadFiles
      // 
      this.uploadFiles.Location = new System.Drawing.Point(10, 190);
      this.uploadFiles.Name = "uploadFiles";
      this.uploadFiles.Size = new System.Drawing.Size(75, 23);
      this.uploadFiles.TabIndex = 2;
      this.uploadFiles.Text = "Upload Files";
      this.uploadFiles.UseVisualStyleBackColor = true;
      this.uploadFiles.Click += new System.EventHandler(this.uploadFiles_Click);
      // 
      // clientId
      // 
      this.clientId.Dock = System.Windows.Forms.DockStyle.Fill;
      this.clientId.Location = new System.Drawing.Point(10, 40);
      this.clientId.Name = "clientId";
      this.clientId.Size = new System.Drawing.Size(206, 20);
      this.clientId.TabIndex = 3;
      this.clientId.Text = "rGm0mO9jVSsD2yBEDk9MRtXQTwsa61y0";
      // 
      // clientSecret
      // 
      this.clientSecret.Dock = System.Windows.Forms.DockStyle.Fill;
      this.clientSecret.Location = new System.Drawing.Point(222, 40);
      this.clientSecret.Name = "clientSecret";
      this.clientSecret.Size = new System.Drawing.Size(206, 20);
      this.clientSecret.TabIndex = 4;
      this.clientSecret.Text = "Wdb16c2ddba244df";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Client Id";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(222, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Client Secret";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 144);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(76, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Assembly Path";
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(10, 84);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(72, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Bucket Name";
      // 
      // bucketName
      // 
      this.bucketName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bucketName.Location = new System.Drawing.Point(10, 100);
      this.bucketName.Name = "bucketName";
      this.bucketName.Size = new System.Drawing.Size(206, 20);
      this.bucketName.TabIndex = 9;
      this.bucketName.Text = "adamenagy_assemblytest";
      // 
      // translateAssembly
      // 
      this.translateAssembly.Location = new System.Drawing.Point(222, 190);
      this.translateAssembly.Name = "translateAssembly";
      this.translateAssembly.Size = new System.Drawing.Size(75, 23);
      this.translateAssembly.TabIndex = 10;
      this.translateAssembly.Text = "Translate";
      this.translateAssembly.UseVisualStyleBackColor = true;
      this.translateAssembly.Click += new System.EventHandler(this.translateAssembly_Click);
      // 
      // progressBar
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.progressBar, 2);
      this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progressBar.Location = new System.Drawing.Point(10, 220);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(418, 14);
      this.progressBar.TabIndex = 11;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(469, 253);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.Text = "Assembly Uploader";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox filePath;
    private System.Windows.Forms.Button showFileDialog;
    private System.Windows.Forms.Button uploadFiles;
    private System.Windows.Forms.TextBox clientId;
    private System.Windows.Forms.TextBox clientSecret;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox bucketName;
    private System.Windows.Forms.Button translateAssembly;
    private System.Windows.Forms.ProgressBar progressBar;
  }
}

