using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ConvertJ
    {
        public static void Serialization<T>(T allzam, string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(allzam);
            File.WriteAllText(path + "\\" + filename, json);
        }

        public static T Deserialization<T>(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = File.ReadAllText(path + "\\" + filename);
            T allzam = JsonConvert.DeserializeObject<T>(json);
            return allzam;
        }
    }
}
