using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamSpeak.Sdk;
using TeamSpeak.Sdk.Client;


namespace testTeamspeakClient
{
    public partial class Form1 : Form
    {

        public tsClient tscli;

        public Form1()
        {
            InitializeComponent();


            Random rnd = new Random();
            int id = rnd.Next(0, 99999);

            string nickname = handles.Settings.get_setting("nickname");

            if (nickname == "")
            {
                Console.WriteLine("Loading Up Base Client ID");
                nickname = "client" + id.ToString();
            }

            string playback_device_name = handles.Settings.get_setting("playback_device");
            string capture_device_name = handles.Settings.get_setting("capture_device");


            //tscli = new tsClient("213.31.71.200", 9989);

            tscli = new tsClient("54.36.166.173", 9989,nickname:nickname,playbackDevName: playback_device_name,captureDevName:capture_device_name);
            //tscli.Connection.TalkStatusChanged += Connection_TalkStatusChanged;
            //tscli.Connection.ClientMovedSubscription += Connection_SubscriptionClientMoved;



            tscli.Connection.SubscribeAll();

            tscli.Connection.ClientMoved += Connection_ClientMoved;
            tscli.Connection.ClientTimeout += Connection_ClientTimeout;
            tscli.Connection.TalkStatusChanged += Connection_TalkStatusChanged;
            tscli.Connection.ClientMessage += Connection_ClientMessage;
            //tscli.add_event("clientappear", Connection_SubscriptionClientMoved);

            

            

            //timer1.Start();
            //timer2.Start();

            Console.WriteLine(tscli.Connection.Status);
            while (tscli.Connection.Status != ConnectStatus.ConnectionEstablished)
            {
                Console.WriteLine(tscli.Connection.Status);
            }
            tscli.Connection.SubscribeAll();
            foreach (Client cl in tscli.Connection.AllClients)
            {
                Console.WriteLine("Loading User: " + cl.Nickname);
                client_join(cl);
            }

            tscli.Connection.Preprocessor.VadLevel = handles.Settings.get_float("vadLevel");
            tscli.Connection.Preprocessor.EchoCanceling = handles.Settings.get_bool("echocancellation");
            tscli.Connection.VolumeModifier = handles.Settings.get_int("volume");


            



            /*
            foreach(SoundDevice sd in Library.GetPlaybackDevices(mode))
            {

            }
            */

            //Task<Channel> c = tscli.Connection.CreateChannel(nickname+ id.ToString(), null, topic: "Hello World", description: "Do not join", isPermanent: false, isSemiPermanent: false);
            // c.Wait();
            // c.RunSynchronously();

            //tscli.Connection.Self.Nickname = nickname;
            /*
            try
            {
                tscli.Connection.Self.MoveTo(c.Result);
            }
            catch { }*/
        }

        private void Connection_ClientMessage(Client from, Client to, string message)
        {
            Console.WriteLine("Message From "+from.Nickname+ ": "+message);
            if (message.StartsWith("%poke%"))
            {

                if (from.ID != to.ID)
                {

                    Console.WriteLine("Poke From User");
                    message = message.Replace("%poke%", "");

                    MessageBox.Show(from.Nickname + " Pokes You: " + message);
                }
                //views.show_poke sp = new views.show_poke(message,from.Nickname);
                //sp.Show();
            }
        }

        private Dictionary<string, List<Client>> teamspeakClientTasks = new Dictionary<string, List<Client>>();

        public void set_clients()
        {
            tscli.Connection.SubscribeAll();
            foreach (Client c in tscli.Connection.AllClients)
            {
                //asVoicerPluginApi.Handle.tsclient[c.ID] = c;
            }
        }

        public void client_join(Client client)
        {
            try
            {
                //asVoicerPluginApi.Handle.tsclient.Connection.SubscribeAll();
            }
            catch { }
            if (!teamspeakClientTasks.ContainsKey("join"))
            {
                teamspeakClientTasks.Add("join", new List<Client>());
            }

            teamspeakClientTasks["join"].Add(client);
           set_clients();
           // asVoicerPluginApi.Handle.tsclient[client.ID] = client;
        }

        public void client_left(Client client)
        {
            try
            {
                //asVoicerPluginApi.Handle.tsclient.Connection.SubscribeAll();
            }
            catch { }
            if (!teamspeakClientTasks.ContainsKey("leave"))
            {
                teamspeakClientTasks.Add("leave", new List<Client>());
            }

            teamspeakClientTasks["leave"].Add(client);
            set_clients();
           // asVoicerPluginApi.Handle.tsclient[client.ID] = client;
        }


        public void remove_client_join(Client client)
        {

            if (teamspeakClientTasks.ContainsKey("join"))
            {
                List<Client> c = teamspeakClientTasks["join"];
                c.Remove(client);
                teamspeakClientTasks["join"] = c;
            }

        }

        public void remove_client_leave(Client client)
        {

            if (teamspeakClientTasks.ContainsKey("leave"))
            {
                List<Client> c = teamspeakClientTasks["leave"];
                c.Remove(client);
                teamspeakClientTasks["leave"] = c;
            }

        }

        private void Connection_ClientTimeout(Client client, Channel oldChannel, Channel newChannel, Visibility visibility, string message)
        {
            //throw new NotImplementedException();
            client_left(client);
        }

        private void Connection_ClientMoved(Client client, Channel oldChannel, Channel newChannel, Visibility visibility, Client invoker, string message)
        {
            if (oldChannel == null)
            {
                Console.WriteLine($"{client.Nickname} Has joined the server - New");
                // create_user_Card(client);
                client_join(client);
            }
            if(newChannel == null)
            {
                Console.WriteLine($"{client.Nickname} Has Left the server - GONE");
                client_left(client);
            }
            Console.WriteLine($"{client.Nickname} moves from channel {oldChannel?.Name ?? "nowhere"} to {newChannel?.Name ?? "nowhere"} with message {message} - New");
        }

        private void Connection_SubscriptionClientMoved(object[] args)
        {
            Client client = (Client)args[0];
            Channel oldChannel = (Channel)args[1];
            Channel newChannel = (Channel)args[2];
            Visibility visibility = (Visibility)args[3];

            Console.WriteLine($"New client2: {client.Nickname}");
            create_client_Card(client);
        }

        private void Connection_TalkStatusChanged(Client client, TalkStatus status, bool isReceivedWhisper)
        {
            update_client_info(client);
        }


        public void create_user_Card(Client client)
        {
            if (client.ID != tscli.Connection.ID)
            {
                views.client cli = new views.client(client);

                cli.Parent = panel1;
                cli.Location = new Point(5, (panel1.Controls.Count * cli.Height) + 5);
                cli.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;

                panel1.Controls.Add(cli);
            }
            else
            {
                lbl_user.Text = client.Nickname;
            }
            //panel1.Invoke((MethodInvoker)(()=>panel1.Controls.Add(cli)));

            /*
            if (!clientlist.ContainsKey(client.ID))
            {
                clientlist.Add(client.ID, client);
            }
            clientlist[client.ID] = client;*/
        }

        public void create_client_Card(Client client)
        {
            views.client cli = new views.client(client);

            cli.Parent = panel1;
            cli.Location = new Point(5, (panel1.Controls.Count * cli.Height) + 5);
            cli.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;

            panel1.Controls.Add(cli);

        }

        public Control get_client_control(int id)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                views.client cl = (views.client)ctrl;
                if (cl.tsClient.ID == id)
                {
                    return ctrl;
                }
            }
            return null;
        }

        public void remove_client_control(Client cl)
        {
            List<Client> tempList = new List<Client>();

            foreach (Control ctrl in panel1.Controls)
            {
                views.client clr = (views.client)ctrl;
                if (clr.tsClient.ID != cl.ID)
                {
                    tempList.Add(clr.tsClient);
                }
            }


            panel1.Controls.Clear();

            foreach(Client c in tempList)
            {
                create_client_Card(c);
            }

        }

        public Dictionary<int, Client> clientlist = new Dictionary<int, Client>();

        public void update_client_info(Client cl)
        {
            clientlist[cl.ID] = cl;
            //asVoicerPluginApi.Handle.tsclient[cl.ID] = cl;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            lbl_user.Text = tscli.Connection.Self.Nickname;

            if (teamspeakClientTasks.ContainsKey("join"))
            {
                List<Client> clis = teamspeakClientTasks["join"];
                if (clis.Count > 0)
                {
                    for (int i = 0; i < clis.Count; i++)
                    {
                        try
                        {
                            Client cr = clis[i];
                            create_client_Card(cr);
                            remove_client_join(cr);
                        }
                        catch { }
                    }
                }
            }
            if (teamspeakClientTasks.ContainsKey("leave"))
            {
                List<Client> clis = teamspeakClientTasks["leave"];
                if (clis.Count > 0)
                {
                    for (int i = 0; i < clis.Count; i++)
                    {
                        try
                        {
                            Client cr = clis[i];
                            //create_client_Card(cr);

                            remove_client_control(cr);

                            remove_client_leave(cr);
                        }
                        catch { }
                    }
                }
            }
            try
            {
                foreach (KeyValuePair<int, Client> ctr1 in clientlist)
                {
                    Client ctr = ctr1.Value;
                    views.client cl = (views.client)get_client_control(ctr.ID);
                    if (cl != null)
                    {
                        cl.update_data(ctr);
                    }
                }
            }
            catch { }


        }

        private void Close_Connection(object sender, FormClosingEventArgs e)
        {
            tscli.Connection.Stop();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

            

            try
            {
                //tscli.Connection.SendTextMessage("cmd=lol&hello=lol&jim=bob");
                Console.WriteLine("Sending Message");
                tscli.Connection.SendTextMessage("Hello");
                tscli.Connection.SendTextMessage("cmd=lol&hello=lol&jim=bob");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Sending Server Command");
            }
        }
    }
}
