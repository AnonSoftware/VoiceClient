using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TeamSpeak.Sdk.Client;
using NAudio.Wave;

namespace testPlugin.views
{
    public partial class SoundPlatform : UserControl
    {
        int pos;
        string file;

        public SoundPlatform(int pos)
        {
            this.pos = pos;
            InitializeComponent();

            string file = handle.Settings.get_setting(pos.ToString());

            load_file_data(file);

        }

        public void load_file_data(string file)
        {
            if (File.Exists(file))
            {//Get File Data

                if(Path.GetExtension(file) != ".wav")
                {
                    string _outPath_ = file.Replace(Path.GetExtension(file), ".wav");
                    using (Mp3FileReader mp3 = new Mp3FileReader(file))
                    {
                        using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                        {
                            WaveFileWriter.CreateWaveFile(_outPath_, pcm);
                        }
                    }


                        file = file.Replace(Path.GetExtension(file), ".wav");
                }

                string displayName = Path.GetFileName(file);
                btn_player.Text = displayName;
                this.file = file;
            }
        }

        private void Btn_player_Click(object sender, EventArgs e)
        {
            //Play File
            //Program.playingSong  = asVoicerPluginApi.api.PlaySound.playSound(file);

            play_sound(file);
        }

        public void play_sound(string file)
        {

            NAudio.Wave.DirectSoundOut waveOut = new NAudio.Wave.DirectSoundOut();

            NAudio.Wave.WaveFileReader wfr = new NAudio.Wave.WaveFileReader(file);
            NAudio.Wave.WaveOut wOut = new NAudio.Wave.WaveOut();
            wOut.DeviceNumber = 0;
            wOut.Init(wfr);
            wOut.Play();

            waveOut.Init(wfr);

            waveOut.Play();



        }

        private void SetFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Audio File";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
                //Save To Config
                handle.Settings.set(pos.ToString(), ofd.FileName);
                load_file_data(ofd.FileName);
            }

        }

        private void rightClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                contextMenuStrip1.Show(ptLowerLeft);
                
            }
        }
    }
}
