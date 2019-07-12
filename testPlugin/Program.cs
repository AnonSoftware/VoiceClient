using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamSpeak.Sdk.Client;

namespace testPlugin
{
    public class Program
    {

        public static WaveHandle playingSong;
        public void PluginEnable(string arg)
        {
            Console.WriteLine("TestPluginb Enable And Register"+arg);
            /*
            foreach(object o in args)
            {
                Console.WriteLine(o.ToString());
            }*/

            asVoicerPluginApi.Handle.register_plugin("testPlugin","hello",1);

        }


        


        public void onEnabled(string s)
        {
            Console.WriteLine("I am enabled");
            asVoicerPluginApi.api.Menu.register_plugin_button("SoundBoard", menuCallback);


        }


        public void menuCallback()
        {
            Console.WriteLine("My Callback Has Worked");


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            SoundBoard sb = new SoundBoard();
            sb.Show();
            sb.load_platforms();
            Console.WriteLine("SoundBoard Displayd");
        }

    }
}
