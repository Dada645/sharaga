// Массив  позволит проверять разные варианты ответов

string answer;
string[] yesVariants = { "yes", "y", "true", "да", "lf"};

do
{
    // Выводим варианты действий

    Console.WriteLine("1. Сложение\r\n2. Вычетание\r\n3. Умножение\r\n4. Деление\r\n5. Степень\r\n6. Квадратный корень\r\n7. Проценты\r\n8. Факториал\r\n9. Выйти из программы");
    Console.WriteLine("Choose your destiny");
    string Operation = Console.ReadLine();


    if (Operation == "9")
    {
        Console.WriteLine("Вы вышли из программы ");
        return;
    }

    // Ввод значений переменных

    Console.WriteLine("Введите первое число:");
    int a1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b1 = Convert.ToInt32(Console.ReadLine());

    // Определяем выбор пользователя и выполняем соответствующее действие

    if (Operation == "1")
    {
        Console.Write("Результат  = ");
        Console.Write(a1 + b1);
    }
    if (Operation == "2")
    {
        Console.Write("Результат  = ");
        Console.Write(a1 - b1);
    }
    if (Operation == "3")
    {
        Console.Write("Результат  = ");
        Console.Write(a1 * b1);
    }
    if (Operation == "4")
    {
        Console.Write("Результат  = ");
        Console.Write(a1 / b1);
    }
    if (Operation == "5")
    {
        Console.Write("Введите степень N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write(Math.Pow(a1, N));
    }
    if (Operation == "6")
    {
        double d = Math.Sqrt(a1);
        Console.Write("корень из первого числа  = ");
        Console.Write(d);
        double c = Math.Sqrt(b1);
        Console.Write("корень из второго числа  = ");
        Console.Write(c);
    }
    if (Operation == "7")
    {
        Console.Write("Результат  = ");
        Console.Write(b1 / 100);
        Console.Write("1% от первого числа  = ");
        Console.Write(a1 / 100);
    }
    if (Operation == "8")
    {
        int c = 1;
        for (int i = 1; a1 >= i; ++i)
        {
            c = c * i;
        }
        Console.WriteLine(c);
    }

    Console.WriteLine("Желаете повторить тест?(Yes/No) ");
  answer = Console.ReadLine();

   // Проверка по массиву ответов
} while (yesVariants.Contains(answer, StringComparer.OrdinalIgnoreCase));