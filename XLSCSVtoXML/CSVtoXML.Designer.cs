namespace XLSCSVtoXML
{
    partial class CSVtoXML
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
            this.actionOpenFile = new System.Windows.Forms.Button();
            this.actionExportFilesToXML = new System.Windows.Forms.Button();
            this.outputSelectedFiles = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.outputProgress = new System.Windows.Forms.Label();
            this.outputFailed = new System.Windows.Forms.ListBox();
            this.outputFailedTag = new System.Windows.Forms.Label();
            this.outputExportFolder = new System.Windows.Forms.TextBox();
            this.actionSelectFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // actionOpenFile
            // 
            this.actionOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionOpenFile.Location = new System.Drawing.Point(307, 12);
            this.actionOpenFile.Name = "actionOpenFile";
            this.actionOpenFile.Size = new System.Drawing.Size(121, 44);
            this.actionOpenFile.TabIndex = 1;
            this.actionOpenFile.Text = "Select files";
            this.actionOpenFile.UseVisualStyleBackColor = true;
            this.actionOpenFile.Click += new System.EventHandler(this.actionOpenFile_Click);
            // 
            // actionExportFilesToXML
            // 
            this.actionExportFilesToXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionExportFilesToXML.Location = new System.Drawing.Point(307, 298);
            this.actionExportFilesToXML.Name = "actionExportFilesToXML";
            this.actionExportFilesToXML.Size = new System.Drawing.Size(121, 30);
            this.actionExportFilesToXML.TabIndex = 2;
            this.actionExportFilesToXML.Text = "Export files as XML";
            this.actionExportFilesToXML.UseVisualStyleBackColor = true;
            this.actionExportFilesToXML.Click += new System.EventHandler(this.actionExportFilesToXML_Click);
            // 
            // outputSelectedFiles
            // 
            this.outputSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputSelectedFiles.FormattingEnabled = true;
            this.outputSelectedFiles.Location = new System.Drawing.Point(12, 12);
            this.outputSelectedFiles.Name = "outputSelectedFiles";
            this.outputSelectedFiles.Size = new System.Drawing.Size(276, 264);
            this.outputSelectedFiles.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // outputProgress
            // 
            this.outputProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputProgress.AutoSize = true;
            this.outputProgress.Location = new System.Drawing.Point(21, 279);
            this.outputProgress.Name = "outputProgress";
            this.outputProgress.Size = new System.Drawing.Size(0, 13);
            this.outputProgress.TabIndex = 4;
            // 
            // outputFailed
            // 
            this.outputFailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFailed.FormattingEnabled = true;
            this.outputFailed.Location = new System.Drawing.Point(313, 75);
            this.outputFailed.Name = "outputFailed";
            this.outputFailed.Size = new System.Drawing.Size(115, 134);
            this.outputFailed.TabIndex = 5;
            this.outputFailed.Visible = false;
            // 
            // outputFailedTag
            // 
            this.outputFailedTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFailedTag.AutoSize = true;
            this.outputFailedTag.Location = new System.Drawing.Point(304, 59);
            this.outputFailedTag.Name = "outputFailedTag";
            this.outputFailedTag.Size = new System.Drawing.Size(62, 13);
            this.outputFailedTag.TabIndex = 6;
            this.outputFailedTag.Text = "Failed files: ";
            this.outputFailedTag.Visible = false;
            // 
            // outputExportFolder
            // 
            this.outputExportFolder.Location = new System.Drawing.Point(12, 305);
            this.outputExportFolder.Name = "outputExportFolder";
            this.outputExportFolder.Size = new System.Drawing.Size(229, 20);
            this.outputExportFolder.TabIndex = 7;
            // 
            // actionSelectFolder
            // 
            this.actionSelectFolder.Location = new System.Drawing.Point(247, 303);
            this.actionSelectFolder.Name = "actionSelectFolder";
            this.actionSelectFolder.Size = new System.Drawing.Size(41, 21);
            this.actionSelectFolder.TabIndex = 8;
            this.actionSelectFolder.Text = "...";
            this.actionSelectFolder.UseVisualStyleBackColor = true;
            this.actionSelectFolder.Click += new System.EventHandler(this.actionSelectFolder_Click);
            // 
            // CSVtoXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 337);
            this.Controls.Add(this.actionSelectFolder);
            this.Controls.Add(this.outputExportFolder);
            this.Controls.Add(this.outputFailedTag);
            this.Controls.Add(this.outputFailed);
            this.Controls.Add(this.outputProgress);
            this.Controls.Add(this.outputSelectedFiles);
            this.Controls.Add(this.actionExportFilesToXML);
            this.Controls.Add(this.actionOpenFile);
            this.MaximizeBox = false;
            this.Name = "CSVtoXML";
            this.Text = "CSV to XML";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button actionOpenFile;
        private System.Windows.Forms.Button actionExportFilesToXML;
        private System.Windows.Forms.ListBox outputSelectedFiles;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label outputProgress;
        private System.Windows.Forms.Label outputFailedTag;
        private System.Windows.Forms.ListBox outputFailed;
        private System.Windows.Forms.TextBox outputExportFolder;
        private System.Windows.Forms.Button actionSelectFolder;
    }
}

