string operation;
do
{
    Console.WriteLine("Выберите программу, которую хотите запустить\n1. Угадай число\n2. Таблица умножения\n3. Вывод делителей числа\n4. Закрыть программу");
    operation = Console.ReadLine();
    if (operation == "4")
    {
        Console.WriteLine("Вы вышли из программы");
    }
    if (operation == "1")
    {
        Random rnd = new Random();
        int value = rnd.Next(0, 100);
        Console.WriteLine("Введи число");
        int lucky = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            if (value > lucky)
            {
                Console.WriteLine("Больше");
                lucky = Convert.ToInt32(Console.ReadLine());
            }
            else if (value < lucky)
            {
                Console.WriteLine("Меньше");
                lucky = Convert.ToInt32(Console.ReadLine());
            }
            if (value == lucky)
            {
                Console.WriteLine("Вы угадали число");
                break;
            }
        }
    }
    if (operation == "2")
    {
        Console.WriteLine("Таблица умножения");
        int[,] matrica = new int[10, 1];
        for (int j = 1; j < 10; j++)
        {
            for (int k = 1; k < 10; k++)
            {
                Console.Write("\t" + j * k);
            }
            Console.WriteLine("\t");
        }
    }    
    if (operation == "3")
    {
        string delimoe;
        do
        {
            Console.WriteLine("Введите делимое, для выхода из программы введите 'выйти'");
            delimoe = Console.ReadLine();
            if (delimoe == "выйти")
            {
                Console.WriteLine("Вы вышли в главное меню");
                break;
            }
            for (int i = 1; i <= Convert.ToInt32(delimoe); i++)
            {
                if (Convert.ToInt32(delimoe) % i == 0)
                {
                    Console.WriteLine("Число {0} делится без остатка на {1}", delimoe, i);
                }
            }
        } while (delimoe != "выйти");
        
    }
} while (operation != "4");