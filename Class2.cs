namespace ConsoleApp777
{
    internal class LOL
    {
        static int position = Tuda_Suda.position, max = Tuda_Suda.max, min = Tuda_Suda.min;
        static ConsoleKey key = Tuda_Suda.button;
        static string path = Base_0.way;
        static void Main()
        {
            Main_0(position, max, min, key, path);
        }
        static void Main_0(int max, int min, int position, ConsoleKey button, string way)
        {
            min = 1; max = 2;
            position = 1;
            Base_0.Base(button, position, max, min, way);
        }
    }
}