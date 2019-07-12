using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace testPlugin.handle
{
    public class Settings
    {
        public static void set(string key, string value)
        {
            Dictionary<string, string> sets = get();

            sets[key] = value;



            string saveData = JsonConvert.SerializeObject(sets);

            File.WriteAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/config.data", saveData);

        }

        public static string get_setting(string key)
        {
            Dictionary<string, string> gets = get();
            if (gets.ContainsKey(key))
            {
                return gets[key];
            }
            return "";
        }
        public static Dictionary<string, string> get()
        {
            if (File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/config.data"))
            {
                string jsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/config.data");
                Dictionary<string, string> settingsData = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonData);
                return settingsData;
            }
            else
            {
                return new Dictionary<string, string>();
            }
        }

        public static bool get_bool(string key)
        {
            Dictionary<string, string> gets = get();
            if (gets.ContainsKey(key))
            {
                string s = gets[key];

                bool _out = false;
                try
                {
                    _out = Convert.ToBoolean(s);
                }
                catch { }
                return _out;
            }
            return false;
        }

        public static void set_bool(string key, bool value)
        {
            set(key, value.ToString());
        }


        public static void set_float(string key, float value)
        {
            set(key, value.ToString());
        }

        public static float get_float(string key)
        {
            Dictionary<string, string> gets = get();
            if (gets.ContainsKey(key))
            {
                string s = gets[key];

                float _out = 0f;
                try
                {
                    _out = float.Parse(s);
                }
                catch { }
                return _out;
            }
            return 0f;
        }


        public static void set_int(string key, int value)
        {
            set(key, value.ToString());
        }

        public static int get_int(string key)
        {
            Dictionary<string, string> gets = get();
            if (gets.ContainsKey(key))
            {
                string s = gets[key];

                int _out = 0;
                try
                {
                    _out = Convert.ToInt32(s);
                }
                catch { }
                return _out;
            }
            return 0;
        }
    }
}
