using System;
using System.IO;
using System.Windows.Forms;
using VideoLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YouTubeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string videoUrl = txtUrl.Text;
            progressBar1.Value = 0;

            if (string.IsNullOrWhiteSpace(videoUrl))
            {
                MessageBox.Show("L�tfen ge�erli bir YouTube linki giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderDialog.SelectedPath;

                try
                {
                    lblStatus.Text = "Durum: �ndiriliyor...";
                    var youtube = YouTube.Default;
                    var video = youtube.GetVideo(videoUrl);

                    string filePath = Path.Combine(folderPath, video.FullName);
                    File.WriteAllBytes(filePath, video.GetBytes());

                    progressBar1.Value = 100;
                    lblStatus.Text = "Durum: �ndirme tamamland�!";
                    MessageBox.Show("Video ba�ar�yla indirildi.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Durum: Hata olu�tu.";
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
