namespace YouTubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUrl = new TextBox();
            btnDownload = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            progressBar1 = new ProgressBar();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 12);
            txtUrl.Name = "txtUrl";
            txtUrl.PlaceholderText = "Video URL";
            txtUrl.Size = new Size(100, 23);
            txtUrl.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(118, 12);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "İndir";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 41);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(181, 23);
            progressBar1.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(16, 45);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "label1";
            // 
            // Form1
            // 
            ClientSize = new Size(596, 363);
            Controls.Add(lblStatus);
            Controls.Add(progressBar1);
            Controls.Add(btnDownload);
            Controls.Add(txtUrl);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Button btnDownload;
        private FolderBrowserDialog folderBrowserDialog1;
        private ProgressBar progressBar1;
        private Label lblStatus;
    }
}
