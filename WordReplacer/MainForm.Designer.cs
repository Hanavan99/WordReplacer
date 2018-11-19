namespace WordReplacer
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
            this.wxReplacementPath = new System.Windows.Forms.TextBox();
            this.wxSourcePath = new System.Windows.Forms.TextBox();
            this.wxReplacementBrowse = new System.Windows.Forms.Button();
            this.wxSourceBrowse = new System.Windows.Forms.Button();
            this.wxDestBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wxDestPath = new System.Windows.Forms.TextBox();
            this.wxClose = new System.Windows.Forms.Button();
            this.wxReplace = new System.Windows.Forms.Button();
            this.wxOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.wxSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.wxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.wxBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.uxExtraOptions = new System.Windows.Forms.GroupBox();
            this.uxSkipMalformed = new System.Windows.Forms.CheckBox();
            this.uxInferFileEncoding = new System.Windows.Forms.CheckBox();
            this.uxReplacementType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxGenerateLogFile = new System.Windows.Forms.CheckBox();
            this.uxExtraOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // wxReplacementPath
            // 
            this.wxReplacementPath.Location = new System.Drawing.Point(167, 12);
            this.wxReplacementPath.Name = "wxReplacementPath";
            this.wxReplacementPath.Size = new System.Drawing.Size(305, 20);
            this.wxReplacementPath.TabIndex = 0;
            // 
            // wxSourcePath
            // 
            this.wxSourcePath.Location = new System.Drawing.Point(167, 38);
            this.wxSourcePath.Name = "wxSourcePath";
            this.wxSourcePath.Size = new System.Drawing.Size(305, 20);
            this.wxSourcePath.TabIndex = 1;
            // 
            // wxReplacementBrowse
            // 
            this.wxReplacementBrowse.Location = new System.Drawing.Point(478, 10);
            this.wxReplacementBrowse.Name = "wxReplacementBrowse";
            this.wxReplacementBrowse.Size = new System.Drawing.Size(30, 23);
            this.wxReplacementBrowse.TabIndex = 2;
            this.wxReplacementBrowse.Text = "...";
            this.wxReplacementBrowse.UseVisualStyleBackColor = true;
            this.wxReplacementBrowse.Click += new System.EventHandler(this.wxReplacementBrowse_Click);
            // 
            // wxSourceBrowse
            // 
            this.wxSourceBrowse.Location = new System.Drawing.Point(478, 36);
            this.wxSourceBrowse.Name = "wxSourceBrowse";
            this.wxSourceBrowse.Size = new System.Drawing.Size(30, 23);
            this.wxSourceBrowse.TabIndex = 3;
            this.wxSourceBrowse.Text = "...";
            this.wxSourceBrowse.UseVisualStyleBackColor = true;
            this.wxSourceBrowse.Click += new System.EventHandler(this.wxSourceBrowse_Click);
            // 
            // wxDestBrowse
            // 
            this.wxDestBrowse.Location = new System.Drawing.Point(478, 62);
            this.wxDestBrowse.Name = "wxDestBrowse";
            this.wxDestBrowse.Size = new System.Drawing.Size(30, 23);
            this.wxDestBrowse.TabIndex = 4;
            this.wxDestBrowse.Text = "...";
            this.wxDestBrowse.UseVisualStyleBackColor = true;
            this.wxDestBrowse.Click += new System.EventHandler(this.wxDestBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Replacement word map file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination file:";
            // 
            // wxDestPath
            // 
            this.wxDestPath.Location = new System.Drawing.Point(167, 64);
            this.wxDestPath.Name = "wxDestPath";
            this.wxDestPath.Size = new System.Drawing.Size(305, 20);
            this.wxDestPath.TabIndex = 8;
            // 
            // wxClose
            // 
            this.wxClose.Location = new System.Drawing.Point(433, 210);
            this.wxClose.Name = "wxClose";
            this.wxClose.Size = new System.Drawing.Size(75, 23);
            this.wxClose.TabIndex = 9;
            this.wxClose.Text = "Close";
            this.wxClose.UseVisualStyleBackColor = true;
            this.wxClose.Click += new System.EventHandler(this.wxCancel_Click);
            // 
            // wxReplace
            // 
            this.wxReplace.Location = new System.Drawing.Point(352, 210);
            this.wxReplace.Name = "wxReplace";
            this.wxReplace.Size = new System.Drawing.Size(75, 23);
            this.wxReplace.TabIndex = 10;
            this.wxReplace.Text = "Replace";
            this.wxReplace.UseVisualStyleBackColor = true;
            this.wxReplace.Click += new System.EventHandler(this.wxReplace_Click);
            // 
            // wxCaseSensitive
            // 
            this.wxCaseSensitive.AutoSize = true;
            this.wxCaseSensitive.Checked = true;
            this.wxCaseSensitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wxCaseSensitive.Location = new System.Drawing.Point(6, 18);
            this.wxCaseSensitive.Name = "wxCaseSensitive";
            this.wxCaseSensitive.Size = new System.Drawing.Size(94, 17);
            this.wxCaseSensitive.TabIndex = 11;
            this.wxCaseSensitive.Text = "Case sensitive";
            this.wxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // wxBackgroundWorker
            // 
            this.wxBackgroundWorker.WorkerReportsProgress = true;
            this.wxBackgroundWorker.WorkerSupportsCancellation = true;
            this.wxBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wxBackgroundWorker_DoWork);
            this.wxBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.wxBackgroundWorker_ProgressChanged);
            this.wxBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wxBackgroundWorker_RunWorkerCompleted);
            // 
            // uxExtraOptions
            // 
            this.uxExtraOptions.Controls.Add(this.uxGenerateLogFile);
            this.uxExtraOptions.Controls.Add(this.uxSkipMalformed);
            this.uxExtraOptions.Controls.Add(this.uxInferFileEncoding);
            this.uxExtraOptions.Controls.Add(this.wxCaseSensitive);
            this.uxExtraOptions.Location = new System.Drawing.Point(10, 117);
            this.uxExtraOptions.Name = "uxExtraOptions";
            this.uxExtraOptions.Size = new System.Drawing.Size(498, 87);
            this.uxExtraOptions.TabIndex = 18;
            this.uxExtraOptions.TabStop = false;
            this.uxExtraOptions.Text = "Extra Options";
            // 
            // uxSkipMalformed
            // 
            this.uxSkipMalformed.AutoSize = true;
            this.uxSkipMalformed.Location = new System.Drawing.Point(6, 64);
            this.uxSkipMalformed.Name = "uxSkipMalformed";
            this.uxSkipMalformed.Size = new System.Drawing.Size(207, 17);
            this.uxSkipMalformed.TabIndex = 13;
            this.uxSkipMalformed.Text = "Skip malformed replacement mappings";
            this.uxSkipMalformed.UseVisualStyleBackColor = true;
            // 
            // uxInferFileEncoding
            // 
            this.uxInferFileEncoding.AutoSize = true;
            this.uxInferFileEncoding.Location = new System.Drawing.Point(6, 41);
            this.uxInferFileEncoding.Name = "uxInferFileEncoding";
            this.uxInferFileEncoding.Size = new System.Drawing.Size(190, 17);
            this.uxInferFileEncoding.TabIndex = 12;
            this.uxInferFileEncoding.Text = "Detect file encodings automatically";
            this.uxInferFileEncoding.UseVisualStyleBackColor = true;
            this.uxInferFileEncoding.CheckedChanged += new System.EventHandler(this.uxInferFileEncoding_CheckedChanged);
            // 
            // uxReplacementType
            // 
            this.uxReplacementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxReplacementType.FormattingEnabled = true;
            this.uxReplacementType.Location = new System.Drawing.Point(274, 90);
            this.uxReplacementType.Name = "uxReplacementType";
            this.uxReplacementType.Size = new System.Drawing.Size(234, 21);
            this.uxReplacementType.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Replacement type:";
            // 
            // uxGenerateLogFile
            // 
            this.uxGenerateLogFile.AutoSize = true;
            this.uxGenerateLogFile.Location = new System.Drawing.Point(240, 18);
            this.uxGenerateLogFile.Name = "uxGenerateLogFile";
            this.uxGenerateLogFile.Size = new System.Drawing.Size(103, 17);
            this.uxGenerateLogFile.TabIndex = 21;
            this.uxGenerateLogFile.Text = "Generate log file";
            this.uxGenerateLogFile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 243);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxReplacementType);
            this.Controls.Add(this.uxExtraOptions);
            this.Controls.Add(this.wxReplace);
            this.Controls.Add(this.wxClose);
            this.Controls.Add(this.wxDestPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wxDestBrowse);
            this.Controls.Add(this.wxSourceBrowse);
            this.Controls.Add(this.wxReplacementBrowse);
            this.Controls.Add(this.wxSourcePath);
            this.Controls.Add(this.wxReplacementPath);
            this.Name = "MainForm";
            this.Text = "Word Replacer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uxExtraOptions.ResumeLayout(false);
            this.uxExtraOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wxReplacementPath;
        private System.Windows.Forms.TextBox wxSourcePath;
        private System.Windows.Forms.Button wxReplacementBrowse;
        private System.Windows.Forms.Button wxSourceBrowse;
        private System.Windows.Forms.Button wxDestBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wxDestPath;
        private System.Windows.Forms.Button wxClose;
        private System.Windows.Forms.Button wxReplace;
        private System.Windows.Forms.OpenFileDialog wxOpenFile;
        private System.Windows.Forms.SaveFileDialog wxSaveFile;
        private System.Windows.Forms.CheckBox wxCaseSensitive;
        private System.ComponentModel.BackgroundWorker wxBackgroundWorker;
        private System.Windows.Forms.GroupBox uxExtraOptions;
        private System.Windows.Forms.CheckBox uxInferFileEncoding;
        private System.Windows.Forms.CheckBox uxSkipMalformed;
        private System.Windows.Forms.CheckBox uxGenerateLogFile;
        private System.Windows.Forms.ComboBox uxReplacementType;
        private System.Windows.Forms.Label label4;
    }
}

