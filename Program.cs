using System;
using System.Reflection;
using System.Text;

namespace Практическая_работа_4
{
    internal class Program
    {
        public static ConsoleKeyInfo zaeb;
        public static int a = 0;
        public static int position = 2;
        public static int w = 0;
        public static int z = 0;
        public static int x = 0;
        static void Main(string[] args)
        {
            Perekluchenie_0();
        }
        public static void List_0()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 25.02.2019");
            zametki.Add("------------------------------------------");
            zametki.Add("  1. Помыть посуду");
            zametki.Add("  2. Помыть стекла");
            w = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        public static void List_1()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 26.02.2019");
            zametki.Add("------------------------------------------");
            zametki.Add("  1. Пропылесосить");
            zametki.Add("  2. Протереть пыль");
            z = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        public static void List_2()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 27.02.2019");
            zametki.Add("------------------------------------------");
            zametki.Add("  1. Сходить по магазинам");
            x = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        static void PodList_0_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Помыть посуду");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Помыть посуду до вечера");
            podzametki.Add("Дата: 25.02.2019");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void PodList_0_2()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Помыть стекла");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Помыть стекла в коридоре");
            podzametki.Add("Дата: 25.02.2019");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void PodList_1_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Пропылесосить");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Пропылесосить во всей квартире");
            podzametki.Add("Дата: 26.02.2019");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void PodList_1_2()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Протереть пыль");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: ППротереть пыль у себя в комнате");
            podzametki.Add("Дата: 26.02.2019");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void PodList_2_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Сходить по магазинам");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Купить водку и пиво");
            podzametki.Add("Дата: 27.02.2019");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void Perekluchenie_0()
        {
            Console.Clear();
            do
            {
                do
                {
                    if (a == 0 && position == 2 && zaeb.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_0_1();
                        zaeb = Console.ReadKey();
                        if (zaeb.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (a == 0 && position == 3 && zaeb.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_0_2();
                        zaeb = Console.ReadKey();
                        if (zaeb.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (a == 1 && position == 2 && zaeb.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_1_1();
                        zaeb = Console.ReadKey();
                        if (zaeb.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (a == 1 && position == 3 && zaeb.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_1_2();
                        zaeb = Console.ReadKey();
                        if (zaeb.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (a == 2 && position == 2 && zaeb.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_2_1();
                        zaeb = Console.ReadKey();
                        if (zaeb.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                } while (zaeb.Key == ConsoleKey.Escape);
                switch (a)
                {
                    case 0:
                        Console.Clear();
                        List_0();
                        Perekluchenie_1();
                        return;
                    case 1:
                        Console.Clear();
                        List_1();
                        Perekluchenie_1();
                        return;
                    case 2:
                        Console.Clear();
                        List_2();
                        Perekluchenie_1();
                        return;
                }
                zaeb = Console.ReadKey();
                switch (zaeb.Key)
                {
                    case ConsoleKey.LeftArrow:
                        a--;
                        switch (a)
                        {
                            case -1:
                                Console.Clear();
                                a = 2;
                                List_2();
                                break;
                            case 0:
                                Console.Clear();
                                List_0();
                                break;
                            case 1:
                                Console.Clear();
                                List_1();
                                break;
                            case 2:
                                Console.Clear();
                                List_2();
                                break;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        a++;
                        switch (a)
                        {
                            case 3:
                                Console.Clear();
                                a = 0;
                                List_0();
                                break;
                            case 0:
                                Console.Clear();
                                List_0();
                                break;
                            case 1:
                                Console.Clear();
                                List_1();
                                break;
                            case 2:
                                Console.Clear();
                                List_2();
                                break;
                        }
                        break;
                }
            } while (zaeb.Key == ConsoleKey.LeftArrow | zaeb.Key == ConsoleKey.RightArrow);
            if (zaeb.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
        
        static void Perekluchenie_1()
        {
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            do
            {
                zaeb = Console.ReadKey();
                if (zaeb.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    if (a == 0 && position == 1)
                    {
                        position++;
                    }
                    if (a == 1 && position == 1)
                    {
                        position++;
                    }
                    if (a == 2 && position == 1)
                    {
                        position++;
                    }
                    Console.Write("->");
                }
                else if (zaeb.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                    if (a == 0 && position == w)
                    {
                        position--;
                    }
                    if (a == 1 && position == z)
                    {
                        position--;
                    }
                    if (a == 2 && position == x)
                    {
                        position--;
                    }
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2) + "\r");
                Console.SetCursorPosition(0, position);
                Console.Write("->");
            } while (zaeb.Key == ConsoleKey.UpArrow | zaeb.Key == ConsoleKey.DownArrow);
            if (zaeb.Key == ConsoleKey.LeftArrow | zaeb.Key == ConsoleKey.RightArrow)
            {
                switch (zaeb.Key)
                {
                    case ConsoleKey.LeftArrow:
                        a--;
                        if (a == -1)
                            a = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        a++;
                        if (a == 3)
                            a = 0;
                        break;
                }
                Perekluchenie_0();
            }
            else if (zaeb.Key == ConsoleKey.Enter)
            {
                Perekluchenie_0();
            }
            if (zaeb.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
    }
}
