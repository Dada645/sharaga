using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Consoep7
{
    internal class Program
    {
        static public ConsoleKeyInfo da_da;
        static void Main(string[] args)
        {
            Converter();
        }
        static void Converter()
        {
            string a;
            string f;
            HH cube_0 = new HH("Квадрат", "16", "16");

            HH rectangle = new HH("Прямоугольник", "45", "26");
            HH cube_1 = new HH("Квадрат", "21", "21");
            List<HH> geo = new List<HH>();
            geo.Add(cube_0);
            geo.Add(rectangle);
            geo.Add(cube_1);
            do
            {
                Console.Clear();
                Console.WriteLine("Введите путь до файла (вместе с названием), который вы хотите открыть\n" + "--------------------------------------------------------------------------");
                a = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Сохранить файл в одном из трех форматов (txt, json, xml) - f1, выйти - Escape\n" + "--------------------------------------------------------------------------");
                f = File.ReadAllText(a);
                if (a.EndsWith("n"))
                {
                    List<HH> gg = JsonConvert.DeserializeObject<List<HH>>(f);
                    foreach (HH name in gg)
                    {
                        Console.WriteLine(name.name);
                        Console.WriteLine(name.value_0);
                        Console.WriteLine(name.value_1);
                    }
                }
                if (a.EndsWith("l"))
                {
                    XmlSerializer x = new XmlSerializer(typeof(HH));
                    HH helicopter ;
                    using (FileStream fs = new FileStream(a, FileMode.OpenOrCreate))
                    {
                        helicopter = (HH)x.Deserialize(fs);
                        Console.WriteLine($"Name: {helicopter?.name}  Age: {helicopter?.value_0}");
                        
                    }
                    Console.WriteLine(helicopter);
                }
                if (a.EndsWith("t"))
                {
                    Console.WriteLine(f);
                }
                da_da = Console.ReadKey();
                if (da_da.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    Console.WriteLine("Введите путь до файла (вместе с названием), куда вы хотите сохранить текст\n" + "--------------------------------------------------------------------------");
                    a = Console.ReadLine();
                    if (a.EndsWith("n"))
                    {
                        string h = JsonConvert.SerializeObject(geo);
                        File.WriteAllText(a, h);
                    }
                    if (a.EndsWith("l"))
                    {
                        XmlSerializer x = new XmlSerializer(typeof(HH));
                        using (FileStream fs = new FileStream(a, FileMode.OpenOrCreate))
                        {
                            x.Serialize(fs, cube_0);
                            x.Serialize(fs, rectangle);
                            x.Serialize(fs, cube_1);
                        }
                    }
                    if (a.EndsWith("t"))
                    {
                        foreach (HH name in geo)
                        {
                            File.WriteAllText(a, null);
                            File.AppendAllText(a, name.name + "\n");
                            File.AppendAllText(a, name.value_0 + "\n");
                            File.AppendAllText(a, name.value_1 + "\n");
                        }
                    }
                }
            } while (da_da.Key != ConsoleKey.Escape);
        }
    }
}