using YoutubeExplode;
using YoutubeExplode.Converter;
using Syroot.Windows.IO;

namespace YoutubeDownloader
{
    public partial class FormDownloader : Form
    {
        public FormDownloader()
        {
            InitializeComponent();
        }
        private void FormDownloader_Load(object sender, EventArgs e)
        {
            txtPath.Text = KnownFolders.Downloads.Path;
            changeFormats();
        }

        private async void btnDescargar_Click(object sender, EventArgs e)
        {
            if (!CheckTXT())
                return;
            await DownloadAsync(txtURLYT.Text, txtPath.Text, listFormato.Text);
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            string path = "";
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            DialogResult result = FBD.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FBD.SelectedPath))
                path = FBD.SelectedPath;
            if (path != "")
                txtPath.Text = path;
        }
        private async Task DownloadAsync(string URL, string path, string formato)
        {
            try
            {
                var client = new YoutubeClient();
                var video = await client.Videos.GetAsync(URL);
                await client.Videos.DownloadAsync(URL, $"{path}/{video.Title}.{formato.ToLower()}", o => o.SetContainer(formato.ToLower()));
                MessageBox.Show("Se descargó correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                switch (ex.Message)
                {
                    case string a when a.Contains("Invalid YouTube video ID or URL"):
                        MessageBox.Show("URL del video inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case string a when a.Contains("is not available"):
                        MessageBox.Show("El video no está disponible debido a un error en la URL o que el video sea privado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void chkChanged(object sender, EventArgs e)
        {
            CheckBox? check = sender as CheckBox;
            if (check.Text == "Video")
            {
                if (check.Checked)
                {
                    chkVideo.Checked = true;
                    chkAudio.Checked = false;
                }
                else
                {
                    chkAudio.Checked = true;
                    chkVideo.Checked = false;
                }
            }
            else if (check.Text == "Audio")
            {
                if (check.Checked)
                {
                    chkVideo.Checked = false;
                    chkAudio.Checked = true;
                }
                else
                {
                    chkAudio.Checked = false;
                    chkVideo.Checked = true;
                }
            }
            changeFormats();
        }

        private void changeFormats()
        {
            listFormato.Items.Clear();
            if (chkVideo.Checked)
            {
                var videoFormats = Downloader.VideoFormats;
                Array.Sort(videoFormats);
                for (int i = 0; i < videoFormats.Length; i++)
                {
                    listFormato.Items.Add(videoFormats[i]);
                }
                listFormato.Text = "";
                listFormato.SelectedText = "MP4";
            }
            else if (chkAudio.Checked)
            {
                var audioFormats = Downloader.AudioFormats;
                Array.Sort(audioFormats);
                for (int i = 0; i < audioFormats.Length; i++)
                {
                    listFormato.Items.Add(audioFormats[i]);
                }
                listFormato.Text = "";
                listFormato.SelectedText = "MP3";
            }
        }

        private bool CheckTXT()
        {
            if (string.IsNullOrEmpty(txtPath.Text))
            {                
                MessageBox.Show("Por favor introduzca una carpeta donde descargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtURLYT.Text))
            {
                MessageBox.Show("Por favor introduzca una URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
