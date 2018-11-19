namespace WordReplacer
{
    partial class ProgressForm
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
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxProgress = new System.Windows.Forms.ProgressBar();
            this.uxProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(187, 55);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 0;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxProgress
            // 
            this.uxProgress.Location = new System.Drawing.Point(12, 26);
            this.uxProgress.Name = "uxProgress";
            this.uxProgress.Size = new System.Drawing.Size(250, 23);
            this.uxProgress.TabIndex = 13;
            // 
            // uxProgressLabel
            // 
            this.uxProgressLabel.AutoSize = true;
            this.uxProgressLabel.Location = new System.Drawing.Point(12, 9);
            this.uxProgressLabel.Name = "uxProgressLabel";
            this.uxProgressLabel.Size = new System.Drawing.Size(110, 13);
            this.uxProgressLabel.TabIndex = 14;
            this.uxProgressLabel.Text = "Getting things ready...";
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 89);
            this.Controls.Add(this.uxProgressLabel);
            this.Controls.Add(this.uxProgress);
            this.Controls.Add(this.uxCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProgressForm";
            this.Text = "Progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.ProgressBar uxProgress;
        private System.Windows.Forms.Label uxProgressLabel;
    }
}