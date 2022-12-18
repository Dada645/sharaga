using System.Diagnostics;

namespace ConsoleApp777
{
    static class Base_0
    {
        public static string way;
        static string open_file;
        public static List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
        static private void Huion_HS611(string openFile, ConsoleKey button, int position, int max, int min, string way)
        {
            Process.Start(new ProcessStartInfo($"{openFile}") { UseShellExecute = true });
            Console.Clear();
            position = 1;
            min = 1;
            max = 2;
            Base(button, position, max, min, way);
        }
        public static void Base(ConsoleKey button, int position, int max, int min, string way)
        {
            DriveInfo Rickey_F_VS_Sin_timeCod_20_35_and_23_51 = drives.First(x => x.Name == "D:\\");
            Console.WriteLine("Выберите диск: ");
            Console.Clear();
            Console.WriteLine("Выберите диск: ");
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady == true)
                {
                    Console.WriteLine($"  Диск: {drive.Name} " + "   Свободное пространство: " + drive.AvailableFreeSpace / 1024 / 1024 / 1024 + " ГБ");
                }
            }
            Base_1(button, position, max, min, way);
        }
        public static void Base_1(ConsoleKey button, int position, int max, int min, string way)
        {
            do
            {
                Tuda_Suda.WR(position);
                button = Console.ReadKey().Key;
                position = Tuda_Suda.CP(position, max, min, button);
                switch (button)
                {
                    case ConsoleKey.Enter:
                        way = Convert.ToString(drives[position - 1]);
                        string dir_name = ($"{way}\\");
                        Console.Clear();
                        var dir = new DirectoryInfo(dir_name);
                        if (dir.Exists)
                        {
                            FileSystemInfo[] sp = dir.GetFileSystemInfos();
                            for (int i = 0; i < sp.Length; i++)
                            {
                                Console.SetCursorPosition(0, i + 1);
                                Console.WriteLine($"  {sp[i].Name}");
                                Console.SetCursorPosition(80, i + 1);
                                Console.WriteLine($"{sp[i].CreationTime}");
                                Console.SetCursorPosition(80, i + 1);
                                Console.WriteLine("   ");
                                Console.SetCursorPosition(110, i + 1);
                                Console.WriteLine($"{sp[i].Extension}");
                            }
                            int length = sp.Length;
                            max = length;
                            bool verification = true;
                            Console.WriteLine();
                            do
                            {
                                Tuda_Suda.WR(position);
                                button = Console.ReadKey().Key;
                                position = Tuda_Suda.CP(position, max, min, button);
                                switch (button)
                                {
                                    case ConsoleKey.Enter:
                                        way = Convert.ToString(sp[position - 1]);
                                        open_file = way;
                                        open_file.TrimEnd('\\');
                                        way = ($"{way}\\");
                                        position = 1;
                                        DIrectory(button, max, min, position, way);
                                        break;
                                    case ConsoleKey.Escape:
                                        Console.Clear();
                                        position = 1;
                                        min = 1;
                                        max = 2;
                                        Base(button, position, max, min, way);
                                        verification = false;
                                        break;

                                }
                            } while (verification);
                        }
                        else
                        {
                            Huion_HS611(open_file, button, position, max, min, way);
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                        break;
                }
            } while (true);
        }
        private static void DIrectory(ConsoleKey button, int position, int max, int min, string way)
        {
            Console.Clear();
            position = 1;
            var directory = new DirectoryInfo(way);
            var file = new FileInfo(way);
            if (directory.Exists)
            {
                FileSystemInfo[] dirs = directory.GetFileSystemInfos();
                for (int i = 0; i < dirs.Length; i++)
                {
                    Console.SetCursorPosition(0, i + 1);
                    Console.WriteLine($"  {dirs[i].Name}");
                    Console.SetCursorPosition(80, i + 1);
                    Console.WriteLine($"{dirs[i].CreationTime}");
                    Console.SetCursorPosition(80, i + 1);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(110, i + 1);
                    Console.WriteLine($"{dirs[i].Extension}");
                }
                int lenght = dirs.Length;
                max = lenght;
                min = lenght - lenght + 1;
                bool verification = true;
                Console.WriteLine();
                do
                {
                    Tuda_Suda.WR(position);
                    button = Console.ReadKey().Key;
                    position = Tuda_Suda.CP(position, max, min, button);
                    switch (button)
                    {
                        case ConsoleKey.Enter:
                            way = Convert.ToString(dirs[position - 1]);
                            open_file = way;
                            open_file.TrimEnd('\\');
                            way = ($"{way}\\");
                            position = 1;
                            DIrectory(button, max, min, position, way);
                            break;
                        case ConsoleKey.Escape:
                            Console.Clear();
                            position = 1;
                            min = 1;
                            max = 2;
                            Base(button, position, max, min, way);
                            verification = false;
                            break;
                    }
                } while (verification);
            }
            else if (file.Exists)
            {
                Huion_HS611(open_file, button, position, max, min, way);
            }
        }
    }
}
