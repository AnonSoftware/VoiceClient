using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamSpeak.Sdk.Client;

namespace testPlugin
{
    public partial class SoundBoard : Form
    {

        int widthCount = 4;
        int heightCount = 5;
        public SoundBoard()
        {
            InitializeComponent();
            Console.WriteLine("INIT");
            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                Console.WriteLine("Device {0}: {1}, {2} channels", waveInDevice, deviceInfo.ProductName, deviceInfo.Channels);
            }
            load_platforms();
        }



        public void load_platforms()
        {
            int xSize = (panel1.Width / widthCount) - (5 * (widthCount - 2));
            int ySize = (panel1.Height / heightCount) - (5 * (heightCount- 2));

            //Console.WriteLine("Load Platofrms");

            int pos = 0;
            int xPos = 5;
            int yPos = 5;
            for (int y = 0; y < heightCount; y++)
            {
                xPos = 5;
                //Console.WriteLine(y);
                for (int x = 0; x < widthCount; x++)
                {
                    //Console.WriteLine(x);
                    views.SoundPlatform spv = new views.SoundPlatform(pos);
                    spv.Parent = panel1;
                    spv.Size = new Size(xSize,ySize);
                    spv.Location = new Point(xPos,yPos);
                    //spv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    //Console.WriteLine("Pos: x:" + xPos.ToString() + " Y:" + yPos);

                    panel1.Controls.Add(spv);
                    pos++;
                    xPos += xSize + 5;
                }
                yPos += ySize + 5;
            }
        }

        private void updateButtons(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            load_platforms();
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

        private void Tb_volume_Scroll(object sender, EventArgs e)
        {
            if(Program.playingSong != null)
            {
                Console.WriteLine(tb_volume.Value);
                try {
                    Program.playingSong.Connection.VolumeFactorWave = tb_volume.Value;
                    asVoicerPluginApi.Handle.tsclient.Connection.VolumeFactorWave = tb_volume.Value;

                } catch {
                    Console.WriteLine("Error setting volume");
                }
            }
        }
    }
}
