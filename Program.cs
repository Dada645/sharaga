﻿using System.Linq.Expressions;
using System.Security.AccessControl;

namespace Практическая_работа_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите Esc для выхода");
            Console.WriteLine("Для перехода между первой и второй октавами нажмите f1 и f2 соответственно ");
            octava_1_1();
            return;
            octava_2_2();
            return;
        }
        static void octava_1_1()
        {
            Console.WriteLine("\nПервая октава");
            int[] octava_1 = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            do
            {
                ConsoleKeyInfo Lox1 = Console.ReadKey();
                switch (Lox1.Key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(octava_1[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(octava_1[1], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(octava_1[2], 200);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(octava_1[3], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(octava_1[4], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(octava_1[5], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(octava_1[6], 200);
                        break;
                    case ConsoleKey.I:
                        Console.Beep(octava_1[7], 200);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(octava_1[8], 200);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(octava_1[9], 200);
                        break;
                    case ConsoleKey.A:
                        Console.Beep(octava_1[10], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(octava_1[11], 200);
                        break;
                    case ConsoleKey.F2:
                        switch_oct_2();
                        return;
                    case ConsoleKey.Escape:
                        return;

                }
            } while (true);
        }
        static void octava_2_2()
        {
            Console.WriteLine("\nВторая октава");
            int[] octava_2 = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            do
            {
                ConsoleKeyInfo Lox1 = Console.ReadKey();
                switch (Lox1.Key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(octava_2[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(octava_2[1], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(octava_2[2], 200);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(octava_2[3], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(octava_2[4], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(octava_2[5], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(octava_2[6], 200);
                        break;
                    case ConsoleKey.I:
                        Console.Beep(octava_2[7], 200);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(octava_2[8], 200);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(octava_2[9], 200);
                        break;
                    case ConsoleKey.A:
                        Console.Beep(octava_2[10], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(octava_2[11], 200);
                        break;
                    case ConsoleKey.F1:
                        switch_oct_1();
                        return;
                    case ConsoleKey.Escape:
                        return;
                }
            } while (true);
        }
        static void switch_oct_1()
        {
            octava_1_1();
        }
        static void switch_oct_2()
        {
            octava_2_2();
        }
    }
}