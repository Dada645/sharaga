using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ClassLibrary1
{
    public class ConvertJ
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