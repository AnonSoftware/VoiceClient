using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamSpeak.Sdk.Client;

namespace testTeamspeakClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        //public static Dictionary<int, Client> client_list = new Dictionary<int, Client>();

        //public static Form1 fm;

        [STAThread]
        static void Main()
        {

            AutoUpdater.Start("http://voicer.anonsoftware.co.uk/update.xml");

            string st = handles.Settings.get_setting("nickname");

            if(st == "")
            {
                st = "Client";
                handles.Settings.set("nickname", "Client");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //fm = new Form1();
            asVoicerPluginApi.Handle.initialize();
            Application.Run(new DesignConcept());


            //Application.Run(fm);
        }

        public static void enable_plugins()
        {
            asVoicerPluginApi.Handle.enablePlugins();
        }

    }
}
