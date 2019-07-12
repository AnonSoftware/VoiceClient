using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using asVoicerPluginApi.classes;
using TeamSpeak.Sdk.Client;

namespace testTeamspeakClient
{
    public partial class DesignConcept : Form
    {
        public DesignConcept()
        {
            InitializeComponent();
            Random rnd = new Random();
            asVoicerPluginApi.Events.MenuButton.register_event(plugin_button_register);
            int id = rnd.Next(0, 99999);

            string nickname = handles.Settings.get_setting("nickname");

            if (nickname == "")
            {
                Console.WriteLine("Loading Up Base Client ID");
                nickname = "client" + id.ToString();
            }

            string playback_device_name = handles.Settings.get_setting("playback_device");
            string capture_device_name = handles.Settings.get_setting("capture_device");

            asVoicerPluginApi.Handle.start_teamspeak_client("54.36.166.173", 9989, nickname: nickname, playbackDevName: playback_device_name, captureDevName: capture_device_name);
            Program.enable_plugins();
        }

        private void plugin_button_register(asVoicerPluginApi.classes.MenuItem mi)
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem();
           // Console.WriteLine(mi.callbk);
            tsmi.Click += (s, e) => { Console.WriteLine("Buttn Call"); mi.run(); };
            tsmi.Text = mi.btn_name;
            contextMenuStripPlugins.Items.Add(tsmi);
        }

        public void show_form(Form objForm)
        {
            //set_progress(0);
            pnl_content.Controls.Clear();
            objForm.TopLevel = false;
            pnl_content.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            //objForm.Load += new EventHandler(formLoaded);
            objForm.Show();
        }


        private void Btn_audio_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(btnSender.Width, 0);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);
        }

        private void Btn_page_users_Click(object sender, EventArgs e)
        {
            show_form(new pages.Users());
        }

        private void MuteMicrophoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(asVoicerPluginApi.Handle.tsclient.Connection.Self.InputMuted)
            {//mic muted

                //asVoicerPluginApi.Handle.tsclient.Connection.Self.Muted = false;
                asVoicerPluginApi.Handle.tsclient.Connection.Self.InputMuted = false;
                muteMicrophoneToolStripMenuItem.Text = "Mute Microphone";
            }
            else
            {
                asVoicerPluginApi.Handle.tsclient.Connection.Self.InputMuted = true;
                muteMicrophoneToolStripMenuItem.Text = "UnMute Microphone";
            }

            
        }

        private void MuteHeadphonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asVoicerPluginApi.Handle.tsclient.Connection.Self.OutputMuted)
            {//headset muted
                asVoicerPluginApi.Handle.tsclient.Connection.Self.OutputMuted = false;
                muteHeadphonesToolStripMenuItem.Text = "Mute Headphones";
            }
            else
            {
                asVoicerPluginApi.Handle.tsclient.Connection.Self.OutputMuted = true;
                muteHeadphonesToolStripMenuItem.Text = "UnMute Headphones";
            }
        }

        private void MuteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asVoicerPluginApi.Handle.tsclient.Connection.Self.OutputMuted || asVoicerPluginApi.Handle.tsclient.Connection.Self.InputMuted)
            {
                asVoicerPluginApi.Handle.tsclient.Connection.Self.InputMuted = false;
                asVoicerPluginApi.Handle.tsclient.Connection.Self.OutputMuted = false;
                muteAllToolStripMenuItem.Text = "Mute All";
                muteHeadphonesToolStripMenuItem.Text = "Mute Headphones";
                muteMicrophoneToolStripMenuItem.Text = "Mute Microphone";
            }
            else
            {
                asVoicerPluginApi.Handle.tsclient.Connection.Self.InputMuted = true;
                asVoicerPluginApi.Handle.tsclient.Connection.Self.OutputMuted = true;
                muteAllToolStripMenuItem.Text = "Unmute All";
                muteHeadphonesToolStripMenuItem.Text = "UnMute Headphones";
                muteMicrophoneToolStripMenuItem.Text = "UnMute Microphone";
            }
        }

        private void Btn_page_settings_Click(object sender, EventArgs e)
        {
            /*
            pages.Settings set = new pages.Settings();
            set.Size = new Size(1200, 700);
            set.Show();*/

            pages.SettingsNew set = new pages.SettingsNew();
            set.Show();
        }

        private void shutdown_ts(object sender, FormClosedEventArgs e)
        {
            try
            {
                asVoicerPluginApi.Handle.tsclient.Connection.Stop();
            }
            catch { }
        }

        private void Btn_create_channel_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(0, 99999);
            Task<Channel> c = asVoicerPluginApi.Handle.tsclient.Connection.CreateChannel(asVoicerPluginApi.Handle.tsclient.Connection.Self.Nickname+ id.ToString(), null, topic: "Hello World", description: "Do not join", isPermanent: false, isSemiPermanent: false);
            // c.Wait();
            // c.RunSynchronously();

            //tscli.Connection.Self.Nickname = nickname;
            
            try
            {
                asVoicerPluginApi.Handle.tsclient.Connection.Self.MoveTo(c.Result);
                Console.WriteLine("Joined Private Channel");
            }
            catch {
                Console.WriteLine("Failed to join private channel");
            }

        }

        private void Btn_plugins_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(btnSender.Width, 0);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStripPlugins.Show(ptLowerLeft);
        }
    }
}
