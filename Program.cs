using Microsoft.VisualBasic;

namespace _5
{
    internal class Podpunkt
    {
        public string name_0;
        public int cost_0;
        public string name_1;
        public int cost_1;
        public string name_2;
        public int cost_2;
    }
        internal class Program
    {
        static public ConsoleKeyInfo da_da;
        DateTime date_0 = DateTime.Now;
        static public string day;
        static public int position = 3;
        static public int a;
        static public string b;
        static public int c = 1;
        static public int d;
        static public int e;
        static void Main(string[] args)
        {
            First();
        }
        static void First()
        {
            Console.Clear();
            Console.WriteLine("Заказ тортов у ПЕТРОВИЧА. Торты на ваш выбор!\n" + "Выберите параметры торта\n" + "---------------------------------------");
            Console.Write("  Форма торта\n" + "  Размер торта\n" + "  Вкус коржей\n" + "  Количество коржей\n" + "  Глазурь\n" + "  Декор\n" + "  Конец заказа\n\n");
            Console.Write("Цена: " + a + "\n" + "Ваш торт: " + b + "\n");
            d = 9;
            Switching_0();
            Switching_1();
        }
        static void Switching_0()
        {
            position = 3;
            do
            {
                if (da_da.Key == ConsoleKey.UpArrow)
                {
                    if (position == 3)
                    {
                        position++;
                    }
                    Console.SetCursorPosition(0, position--);
                    Console.Write("->");
                }
                else if (da_da.Key == ConsoleKey.DownArrow)
                {
                    if (d == 5 && position == 5 || d == 9 && position == 9)
                    {
                        position--;
                    }
                    Console.SetCursorPosition(0, position++);
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2));
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                da_da = Console.ReadKey();
                if (da_da.Key == ConsoleKey.Escape)
                {
                    c = 1;
                    d = 9;
                    First();
                    da_da = Console.ReadKey();
                    return;
                }
            } while (da_da.Key != ConsoleKey.Enter);

        }
        static void Switching_1()
        {
            e = 2;
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Esc\n" + "Выберите пункт из меню\n" + "---------------------------------------");
            c = 2;
            d = 5;
            if (da_da.Key == ConsoleKey.Enter)
            {
                Podpunkt forma = new Podpunkt();
                forma.name_0 = "Круглый";
                forma.cost_0 = 500;
                forma.name_1 = "Квадратный";
                forma.cost_1 = 500;
                forma.name_2 = "Овальный";
                forma.cost_2 = 500;
                Podpunkt size = new Podpunkt();
                size.name_0 = "Маленький - (400 г)";
                size.cost_0 = 1000;
                size.name_1 = "Средний - (800 г)";
                size.cost_1 = 1200;
                size.name_2 = "Большой - (1500 г)";
                size.cost_2 = 2000;
                Podpunkt taste = new Podpunkt();
                taste.name_0 = "Ванильный";
                taste.cost_0 = 100;
                taste.name_1 = "Шоколадный";
                taste.cost_1 = 100;
                taste.name_2 = "Карамельный";
                taste.cost_2 = 100;
                Podpunkt amount = new Podpunkt();
                amount.name_0 = "Один корж";
                amount.cost_0 = 300;
                amount.name_1 = "Два коржа";
                amount.cost_1 = 600;
                amount.name_2 = "Три коржа";
                amount.cost_2 = 900;
                Podpunkt glaze = new Podpunkt();
                glaze.name_0 = "Бизе";
                glaze.cost_0 = 100;
                glaze.name_1 = "Ягоды";
                glaze.cost_1 = 200;
                glaze.name_2 = "Карамельная";
                glaze.cost_2 = 150;
                Podpunkt decor = new Podpunkt();
                decor.name_0 = "Фигурка";
                decor.cost_0 = 500;
                decor.name_1 = "Шоколадная крошка";
                decor.cost_1 = 100;
                decor.name_2 = "Посыпка";
                decor.cost_2 = 100;

                if (position == 3)
                {
                    Console.WriteLine("  " + forma.name_0 + " - " + forma.cost_0 + "\n" + "  " + forma.name_1 + " - " + forma.cost_1 + "\n" + "  " + forma.name_2 + " - " + forma.cost_2 + "\n");
                    position = 3;
                    Switching_0();
                    if (da_da.Key == ConsoleKey.Enter)
                    {
                        switch (position)
                        {
                            case 3:
                                a = a + forma.cost_0;
                                b = b + forma.name_0 + "; ";
                                break;
                            case 4:
                                a = a + forma.cost_1;
                                b = b + forma.name_1 + "; ";
                                break;
                            case 5:
                                a = a + forma.cost_2;
                                b = b + forma.name_2 + "; ";
                                break;
                        }
                        First();
                        return;
                    }
                }
                if (position == 4)
                {
                    Console.WriteLine("  " + size.name_0 + " - " + size.cost_0 + "\n" + "  " + size.name_1 + " - " + size.cost_1 + "\n" + "  " + size.name_2 + " - " + size.cost_2 + "\n");
                    position = 3;
                    Switching_0();
                    if (da_da.Key == ConsoleKey.Enter)
                    {
                        switch (position)
                        {
                            case 3:
                                a = a + size.cost_0;
                                b = b + size.name_0 + "; ";
                                break;
                            case 4:
                                a = a + size.cost_1;
                                b = b + size.name_1 + "; ";
                                break;
                            case 5:
                                a = a + size.cost_2;
                                b = b + size.name_2 + "; ";
                                break;
                        }
                        First();
                        return;
                    }
                }
                if (position == 5)
                {
                    Console.WriteLine("  " + taste.name_0 + " - " + taste.cost_0 + "\n" + "  " + taste.name_1 + " - " + taste.cost_1 + "\n" + "  " + taste.name_2 + " - " + taste.cost_2 + "\n");
                    position = 3;
                    Switching_0();
                    if (da_da.Key == ConsoleKey.Enter)
                    {
                        switch (position)
                        {
                            case 3:
                                a = a + taste.cost_0;
                                b = b + taste.name_0 + "; ";
                                break;
                            case 4:
                                a = a + taste.cost_1;
                                b = b + taste.name_1 + "; ";
                                break;
                            case 5:
                                a = a + taste.cost_2;
                                b = b + taste.name_2 + "; ";
                                break;
                        }
                        First();
                        return;
                    }
                }
                if (position == 6)
                {
                    Console.WriteLine("  " + amount.name_0 + " - " + amount.cost_0 + "\n" + "  " + amount.name_1 + " - " + amount.cost_1 + "\n" + "  " + amount.name_2 + " - " + amount.cost_2 + "\n");
                    position = 3;
                    Switching_0();
                    if (da_da.Key == ConsoleKey.Enter)
                    {
                        switch (position)
                        {
                            case 3:
                                a = a + amount.cost_0;
                                b = b + amount.name_0 + "; ";
                                break;
                            case 4:
                                a = a + amount.cost_1;
                                b = b + amount.name_1 + "; ";
                                break;
                            case 5:
                                a = a + amount.cost_2;
                                b = b + amount.name_2 + "; ";
                                break;
                        }
                        First();
                        return;
                    }
                }
                if (position == 7)
                {
                    Console.WriteLine("  " + glaze.name_0 + " - " + glaze.cost_0 + "\n" + "  " + glaze.name_1 + " - " + glaze.cost_1 + "\n" + "  " + glaze.name_2 + " - " + glaze.cost_2 + "\n");
                    position = 3;
                    Switching_0();
                    if (da_da.Key == ConsoleKey.Enter)
                    {
                        switch (position)
                        {
                            case 3:
                                a = a + glaze.cost_0;
                                b = b + glaze.name_0 + "; ";
                                break;
                            case 4:
                                a = a + glaze.cost_1;
                                b = b + glaze.name_1 + "; ";
                                break;
                            case 5:
                                a = a + glaze.cost_2;
                                b = b + glaze.name_2 + "; ";
                                break;
                        }
                        First();
                        return;
                    }
                }
                if (position == 8)
                {
                    Console.WriteLine("  " + decor.name_0 + " - " + decor.cost_0 + "\n" + "  " + decor.name_1 + " - " + decor.cost_1 + "\n" + "  " + decor.name_2 + " - " + decor.cost_2 + "\n");
                    position = 3;
                    Switching_0();
                    if (da_da.Key == ConsoleKey.Enter)
                    {
                        switch (position)
                        {
                            case 3:
                                a = a + decor.cost_0;
                                b = b + decor.name_0 + "; ";
                                break;
                            case 4:
                                a = a + decor.cost_1;
                                b = b + decor.name_1 + "; ";
                                break;
                            case 5:
                                a = a + decor.cost_2;
                                b = b + decor.name_2 + "; ";
                                break;
                        }
                        First();
                        return;
                    }
                }
                if (position == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Спасибо за заказ! Чтобы сделать еще один нажмите R, чтобы выйти - Esc");
                    day = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                    File.AppendAllText("C:\\Users\\Andrey\\Desktop\\торты.txt", "Текущая дата: " + day + "\n" + "Ваш заказ: " + b + "\n" + "Цена: " + a + "\n");
                    da_da = Console.ReadKey();
                    if (da_da.Key == ConsoleKey.R)
                    {
                        a = 0;
                        b = " ";
                        c = 1;
                        d = 9;
                        First();
                        return;
                    }
                    if (da_da.Key == ConsoleKey.Escape)
                    {
                        return;
                    }

                }
            }
        }
    }
}