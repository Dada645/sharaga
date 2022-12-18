using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp777
{
    internal class Tuda_Suda
    {
        public static ConsoleKey button;
        public static int position = 0;
        public static int max = 0;
        public static int min = 0;
        Tuda_Suda(int MIN, int MAX)
        {
            int min = MIN;
            int max = MAX;
        }
        public static int CP(int position, int max, int min, ConsoleKey button)
        {
            switch (button)
            {

                case ConsoleKey.UpArrow:
                    position--;
                    if (position < min)
                    {
                        position = min;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    position++;
                    if (position > max)
                    {
                        position = max;
                    };
                    break;
            }
            return position;
        }
        public static void WR(int position)
        {
            Console.Write("\r" + new string(' ', 2));
            Console.SetCursorPosition(0, position);
            Console.Write("->");
        }
    }
}
