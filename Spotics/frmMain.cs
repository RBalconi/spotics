using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Spotics {
    public partial class frmMain : Form {
        
        public static string _currentSong = "";
        private bool toggleAutoRefresh = true;
        private bool saveTXT = true;

        public frmMain() {
            InitializeComponent();

            cbSizeFont.SelectedIndex = 2;
            ReadTXT();
            if (toggleAutoRefresh) {
                timer.Enabled = true;
            }
            panelConfig.Visible = false;
        }


        public void RefreshSong() {
            labelTocando.Text = GetSpotifyTrackInfo();
        }

        public void UpdateSong() {
            if (labelTocando.Text != _currentSong) {
                _currentSong = labelTocando.Text;
                DownloadDetails(labelTocando.Text);
            }
        }

        private static string GetSpotifyTrackInfo(){
            var proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null){
                return "Spotify não está rodando!";
            }
            if (string.Equals(proc.MainWindowTitle, "Spotify", StringComparison.InvariantCultureIgnoreCase)){
                return "Pausado";
            }
            return proc.MainWindowTitle;
        }

        private void DownloadDetails(string track){
            string[] data = track.Split('-');
            string artist = "";
            string music = "";
          
            if (data.Length > 1) {
                artist = data[0];
                music = data[1];
            } 

            string key = "";

            using (var wc = new WebClient()){
                var uri = new Uri($"https://api.vagalume.com.br/search.php?art={artist}&mus={music}&apikey={key}");
                wc.DownloadStringCompleted += wc_DownloadStringCompleted;
                wc.DownloadStringAsync(uri);
            }
        }
        
        private void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e){
            try{
                var json = e.Result;
                SongDetails result = JsonConvert.DeserializeObject<SongDetails>(json);
                if (result.type.Contains("notfound")) {
                    textBoxLetra.Text = "Ocorreu algum erro! Música não reconhecida.";
                } else {
                    textBoxLetra.Text = result.mus[0].text.Replace("\n", Environment.NewLine);
                }
            }catch{
                textBoxLetra.Text = "Ocorreu algum erro! Música não reconhecida.";
            }
        }

        private void SaveTXT(int _fontSize, bool _autoRefresh) {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            //string path = Path.GetDirectoryName(Application.ExecutablePath);


            File.Delete(@path + "data.txt");

            FileStream fs = new FileStream(@path + "data.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(_fontSize);
            sw.WriteLine(_autoRefresh);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void ReadTXT() {
            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "data.txt";

            if (File.Exists(path)) {

                string[] lines = File.ReadAllLines(path);
                
                cbSizeFont.SelectedIndex = cbSizeFont.FindStringExact(lines[0]);
                toggleAutoRefresh = bool.Parse(lines[1]);
                if (toggleAutoRefresh) {
                    switchSongOn.Visible = true;
                    switchSongOff.Visible = false;

                } else {
                    switchSongOn.Visible = false;
                    switchSongOff.Visible = true;
                }

            }

        }

     


        //-------------------------

        private void cbSizeFont_SelectedValueChanged(object sender, EventArgs e) {
            Font font = new Font(textBoxLetra.Font.FontFamily, Int32.Parse(cbSizeFont.SelectedItem.ToString()));
            textBoxLetra.Font = font;
            
            //SaveTXT(Int32.Parse(cbSizeFont.SelectedItem.ToString()), true);
        }

        private void pictureBox2_Click(object sender, EventArgs e){
            this.Close();
            SaveTXT(Int32.Parse(cbSizeFont.SelectedItem.ToString()), saveTXT);
        }

        private void pictureBox4_Click(object sender, EventArgs e){
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgCloseConfg_Click(object sender, EventArgs e){
            panelConfig.Visible = false;
            SaveTXT(Int32.Parse(cbSizeFont.SelectedItem.ToString()), saveTXT);
        }
        private void imgConfg_Click(object sender, EventArgs e){
            panelConfig.Visible = true;            
        }
        
        private void timer_Tick(object sender, EventArgs e) {
            RefreshSong();
            UpdateSong();
        }

        private void switchSong_SwitchStateChanged(object sender, EventArgs e) {
            
            if (toggleAutoRefresh == false) {
                timer.Enabled = true;
                toggleAutoRefresh = false;
                saveTXT = true;
                //SaveTXT(Int32.Parse(cbSizeFont.SelectedItem.ToString()), saveTXT);
            } else {
                timer.Enabled = false;
                toggleAutoRefresh = true;
                saveTXT = false;
                //SaveTXT(Int32.Parse(cbSizeFont.SelectedItem.ToString()), false);
            }
        }


        private void switchSongOff_SwitchStateChanged(object sender, EventArgs e) {
            if (toggleAutoRefresh == false) {
                timer.Enabled = true;
                toggleAutoRefresh = false;
                saveTXT = true;
                //SaveTXT(Int32.Parse(cbSizeFont.SelectedItem.ToString()), true);
            } else {
                timer.Enabled = false;
                toggleAutoRefresh = true;
                saveTXT = false;
                //SaveTXT(Int32.Parse(cbSizeFont.SelectedItem.ToString()), false);
            }
        }


    }
}