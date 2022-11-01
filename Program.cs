using Microsoft.VisualBasic;

namespace _5
{
    public class Podpunkt
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
        static public int position = 3;
        static public int full_cost;
        static public string all_position_cake;
        static public int limit;
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Заказ тортов у ПЕТРОВИЧА. Торты на ваш выбор!\n" + "Выберите параметры торта\n" + "---------------------------------------------");
            Console.Write("  Форма торта\n" + "  Размер торта\n" + "  Вкус коржей\n" + "  Количество коржей\n" + "  Глазурь\n" + "  Декор\n" + "  Конец заказа\n\n");
            Console.Write("Цена: " + full_cost + "\n" + "Ваш торт: " + all_position_cake + "\n");
            limit = 9;
            Switching();
            Pod_Main();
        }
        static void Switching()
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
                    if (limit == 5 && position == 5 || limit == 9 && position == 9)
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
                    limit = 9;
                    Main();
                    da_da = Console.ReadKey();
                    return;
                }
            } while (da_da.Key != ConsoleKey.Enter);

        }
        static void Pod_Main()
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Esc\n" + "Выберите пункт из меню\n" + "----------------------");
            limit = 5;

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
                Switching();
                if (da_da.Key == ConsoleKey.Enter)
                {
                    switch (position)
                    {
                        case 3:
                            full_cost = full_cost + forma.cost_0;
                            all_position_cake = all_position_cake + forma.name_0 + "; ";
                            break;
                        case 4:
                            full_cost = full_cost + forma.cost_1;
                            all_position_cake = all_position_cake + forma.name_1 + "; ";
                            break;
                        case 5:
                            full_cost = full_cost + forma.cost_2;
                            all_position_cake = all_position_cake + forma.name_2 + "; ";
                            break;
                    }
                    Main();
                    return;
                }
            }
            if (position == 4)
            {
                Console.WriteLine("  " + size.name_0 + " - " + size.cost_0 + "\n" + "  " + size.name_1 + " - " + size.cost_1 + "\n" + "  " + size.name_2 + " - " + size.cost_2 + "\n");
                Switching();
                if (da_da.Key == ConsoleKey.Enter)
                {
                    switch (position)
                    {
                        case 3:
                            full_cost = full_cost + size.cost_0;
                            all_position_cake = all_position_cake + size.name_0 + "; ";
                            break;
                        case 4:
                            full_cost = full_cost + size.cost_1;
                            all_position_cake = all_position_cake + size.name_1 + "; ";
                            break;
                        case 5:
                            full_cost = full_cost + size.cost_2;
                            all_position_cake = all_position_cake + size.name_2 + "; ";
                            break;
                    }
                    Main();
                    return;
                }
            }
            if (position == 5)
            {
                Console.WriteLine("  " + taste.name_0 + " - " + taste.cost_0 + "\n" + "  " + taste.name_1 + " - " + taste.cost_1 + "\n" + "  " + taste.name_2 + " - " + taste.cost_2 + "\n");
                Switching();
                if (da_da.Key == ConsoleKey.Enter)
                {
                    switch (position)
                    {
                        case 3:
                            full_cost = full_cost + taste.cost_0;
                            all_position_cake = all_position_cake + taste.name_0 + "; ";
                            break;
                        case 4:
                            full_cost = full_cost + taste.cost_1;
                            all_position_cake = all_position_cake + taste.name_1 + "; ";
                            break;
                        case 5:
                            full_cost = full_cost + taste.cost_2;
                            all_position_cake = all_position_cake + taste.name_2 + "; ";
                            break;
                    }
                    Main();
                    return;
                }
            }
            if (position == 6)
            {
                Console.WriteLine("  " + amount.name_0 + " - " + amount.cost_0 + "\n" + "  " + amount.name_1 + " - " + amount.cost_1 + "\n" + "  " + amount.name_2 + " - " + amount.cost_2 + "\n");
                Switching();
                if (da_da.Key == ConsoleKey.Enter)
                {
                    switch (position)
                    {
                        case 3:
                            full_cost = full_cost + amount.cost_0;
                            all_position_cake = all_position_cake + amount.name_0 + "; ";
                            break;
                        case 4:
                            full_cost = full_cost + amount.cost_1;
                            all_position_cake = all_position_cake + amount.name_1 + "; ";
                            break;
                        case 5:
                            full_cost = full_cost + amount.cost_2;
                            all_position_cake = all_position_cake + amount.name_2 + "; ";
                            break;
                    }
                    Main();
                    return;
                }
            }
            if (position == 7)
            {
                Console.WriteLine("  " + glaze.name_0 + " - " + glaze.cost_0 + "\n" + "  " + glaze.name_1 + " - " + glaze.cost_1 + "\n" + "  " + glaze.name_2 + " - " + glaze.cost_2 + "\n");
                Switching();
                if (da_da.Key == ConsoleKey.Enter)
                {
                    switch (position)
                    {
                        case 3:
                            full_cost = full_cost + glaze.cost_0;
                            all_position_cake = all_position_cake + glaze.name_0 + "; ";
                            break;
                        case 4:
                            full_cost = full_cost + glaze.cost_1;
                            all_position_cake = all_position_cake + glaze.name_1 + "; ";
                            break;
                        case 5:
                            full_cost = full_cost + glaze.cost_2;
                            all_position_cake = all_position_cake + glaze.name_2 + "; ";
                            break;
                    }
                    Main();
                    return;
                }
            }
            if (position == 8)
            {
                Console.WriteLine("  " + decor.name_0 + " - " + decor.cost_0 + "\n" + "  " + decor.name_1 + " - " + decor.cost_1 + "\n" + "  " + decor.name_2 + " - " + decor.cost_2 + "\n");
                Switching();
                if (da_da.Key == ConsoleKey.Enter)
                {
                    switch (position)
                    {
                        case 3:
                            full_cost = full_cost + decor.cost_0;
                            all_position_cake = all_position_cake + decor.name_0 + "; ";
                            break;
                        case 4:
                            full_cost = full_cost + decor.cost_1;
                            all_position_cake = all_position_cake + decor.name_1 + "; ";
                            break;
                        case 5:
                            full_cost = full_cost + decor.cost_2;
                            all_position_cake = all_position_cake + decor.name_2 + "; ";
                            break;
                    }
                    Main();
                    return;
                }
            }
            if (position == 9)
            {
                Console.Clear();
                Console.WriteLine("Спасибо за заказ! Чтобы сделать еще один нажмите R, чтобы выйти - Esc");
                string day = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                if (full_cost > 0)
                {
                    File.AppendAllText("C:\\Users\\Andrey\\Desktop\\торты.txt", "Текущая дата: " + day + "\n" + "Ваш заказ: " + all_position_cake + "\n" + "Цена: " + full_cost + "\n");
                }
                else
                {
                    File.AppendAllText("C:\\Users\\Andrey\\Desktop\\торты.txt", "Текущая дата: " + day + "\n" + "Пользователь ничего не заказал :(" + "\n");
                }
                da_da = Console.ReadKey();
                if (da_da.Key == ConsoleKey.R)
                {
                    full_cost = 0;
                    all_position_cake = " ";
                    limit = 9;
                    Main();
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