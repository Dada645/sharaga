using System;
using System.Data;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Практическая_работа_4
{
    internal class Program
    {
        public static ConsoleKeyInfo da_da;
        public static DateTime date_0 = new DateTime(2022, 07, 14);
        public static int position = 2;
        public static int a = 0;
        public static string day;
        static void Main(string[] args)
        {
            Switching();
        }
        static void List_0_1()
        {
            List<string> zametki = new List<string>();
            zametki.Add("14.07.2022");
            zametki.Add("   Погулять с собакой");
            zametki.Add("Описание: Погулять с собакой вечером");
            zametki.Add("   Помыть посуду");
            zametki.Add("Описание: Помыть посуду до приезда мамы");
            zametki.Add("15.07.2022");
            zametki.Add("   Сходить в магазин");
            zametki.Add("Описание: Купить воду и молоко");
            zametki.Add("   Протереть пыль");
            zametki.Add("Описание: Протереть пыль у себя в комнате");
            zametki.Add("16.07.2022");
            zametki.Add("   Погулять");
            zametki.Add("Описание: Позвонить Диме");
            zametki.Add("   Посмотреть сериал");
            zametki.Add("Описание: Купить попкорн к сериалу");
            if (da_da.Key == ConsoleKey.V)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите дату для добавления заметки");
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("Выбрана дата: " + date_0);
                da_da = Console.ReadKey();
                a = 2;
                if (da_da.Key != ConsoleKey.Enter)
                {
                    Switching_1();
                }
                day = date_0.ToString("dd.MM.yyyy");
                zametki.Add(day);
                Console.WriteLine(zametki[13]);
                Console.WriteLine("Введите заголовок заметки");
                string vvod_0 = Console.ReadLine();
                zametki.Add(vvod_0);
                Console.WriteLine("Введите описание заметки");
                string vvod_1 = Console.ReadLine();
                zametki.Add(vvod_1);
                Console.WriteLine("Ура! Вы добавили новую заметку. Нажмите любую клавишу для выхода");
                da_da = Console.ReadKey();
                Console.Clear();
                Switching();
            }
            if (da_da.Key == ConsoleKey.Enter)
            {
                do
                {
                    if (position == 1 && date_0 == new DateTime(2022, 07, 14))
                    {
                        Console.Clear();
                        Console.WriteLine(zametki[1] + "\n" + zametki[2] + "\n" + date_0);
                        break;
                    }
                    if (position == 2 && date_0 == new DateTime(2022, 07, 14))
                    {
                        Console.Clear();
                        Console.WriteLine(zametki[3] + "\n" + zametki[4] + "\n" + date_0);
                        break;
                    }
                    if (position == 1 && date_0 == new DateTime(2022, 07, 15))
                    {
                        Console.Clear();
                        Console.WriteLine(zametki[6] + "\n" + zametki[7] + "\n" + date_0);
                        break;
                    }
                    if (position == 2 && date_0 == new DateTime(2022, 07, 15))
                    {
                        Console.Clear();
                        Console.WriteLine(zametki[8] + "\n" + zametki[9] + "\n" + date_0);
                        break;
                    }
                    if (position == 1 && date_0 == new DateTime(2022, 07, 16))
                    {
                        Console.Clear();
                        Console.WriteLine(zametki[11] + "\n" + zametki[12] + "\n" + date_0);
                        break;
                    }
                    if (position == 2 && date_0 == new DateTime(2022, 07, 16))
                    {
                        Console.Clear();
                        Console.WriteLine(zametki[13] + "\n" + zametki[14] + "\n" + date_0);
                        break;
                    }
                } while (true);
                da_da = Console.ReadKey();
                if (da_da.Key == ConsoleKey.Escape)
                {
                    Switching();
                    return;
                }
            }
            else
            {
                if (date_0 == new DateTime(2022, 07, 14))
                {
                    for (int t = 1; t < 15; t++)
                    {
                        Console.SetCursorPosition(3, t);
                        Console.Write("\r" + new string(' ', 100));
                    }
                    Console.SetCursorPosition(0, 1);
                    Console.Write(zametki[1] + "\n" + zametki[3]);
                    Console.SetCursorPosition(0, position);
                    Console.Write("->");
                }
                else if (date_0 == new DateTime(2022, 07, 15))
                {
                    for (int t = 2; t < 15; t++)
                    {
                        Console.SetCursorPosition(3, t);
                        Console.Write("\r" + new string(' ', 100));
                    }
                    Console.SetCursorPosition(0, 1);
                    Console.Write(zametki[6] + "\n" + zametki[8]);
                    Console.SetCursorPosition(0, position);
                    Console.Write("->");
                }
                else if (date_0 == new DateTime(2022, 07, 16))
                {
                    for (int t = 2; t < 15; t++)
                    {
                        Console.SetCursorPosition(3, t);
                        Console.Write("\r" + new string(' ', 100));
                    }
                    Console.SetCursorPosition(0, 1);
                    Console.Write(zametki[11] + "\n" + zametki[13]);
                    Console.SetCursorPosition(0, position);
                    Console.Write("->");
                }
                else
                {
                    for (int t = 2; t < 15; t++)
                    {
                        Console.SetCursorPosition(3, t);
                        Console.Write("\r" + new string(' ', 100));
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                    }
                }
            }
        }
        static void Switching()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата: " + date_0);
            List_0_1();
            do
            {
                if (da_da.Key == ConsoleKey.LeftArrow | da_da.Key == ConsoleKey.RightArrow)
                {
                    a = 1;
                    Switching_1();
                }
                if (da_da.Key == ConsoleKey.UpArrow)
                {
                    if (position == 1)
                    {
                        position++;
                    }
                    Console.SetCursorPosition(0, position--);
                    Console.Write("->");
                }
                else if (da_da.Key == ConsoleKey.DownArrow)
                {
                    if (position == 2)
                    {
                        position--;
                    }
                    Console.SetCursorPosition(0, position++);
                    Console.Write("->");
                }
                if (da_da.Key == ConsoleKey.V)
                {
                    List_0_1();
                }
                if (da_da.Key == ConsoleKey.Enter)
                {
                    List_0_1();
                    return;
                }
                Console.Write("\r" + new string(' ', 2));
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                da_da = Console.ReadKey();
                if (da_da.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (true);
        }
        static void Switching_1()
        {
            do
            {
                if (da_da.Key == ConsoleKey.LeftArrow)
                {
                    if (a == 1)
                    {
                        Console.SetCursorPosition(0, 0);
                        date_0 = date_0.AddDays(-1);
                        Console.WriteLine("Выбрана дата: " + date_0);
                        Console.Write("\r" + new string(' ', 100));
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                        List_0_1();
                    }
                    if (a == 2)
                    {
                        Console.SetCursorPosition(0, 1);
                        date_0 = date_0.AddDays(-1);
                        Console.WriteLine("Выбрана дата: " + date_0);
                        Console.Write("\r" + new string(' ', 100));
                    }
                }
                if (da_da.Key == ConsoleKey.RightArrow)
                {
                    if (a == 1)
                    {
                        Console.SetCursorPosition(0, 0);
                        date_0 = date_0.AddDays(+1);
                        Console.WriteLine("Выбрана дата: " + date_0);
                        Console.Write("\r" + new string(' ', 100));
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                        List_0_1();
                    }
                    if (a == 2)
                    {
                        Console.SetCursorPosition(0, 1);
                        date_0 = date_0.AddDays(+1);
                        Console.WriteLine("Выбрана дата: " + date_0);
                        Console.Write("\r" + new string(' ', 100));
                    }
                }
                if (da_da.Key == ConsoleKey.V)
                {
                    List_0_1();
                }
                if (da_da.Key == ConsoleKey.UpArrow | da_da.Key == ConsoleKey.DownArrow)
                {
                    if (a == 1)
                    {
                        Switching();
                    }
                }
                if (da_da.Key == ConsoleKey.Escape)
                {
                    return;
                }
                da_da = Console.ReadKey();
            } while (da_da.Key != ConsoleKey.Enter);
        }
    }
}