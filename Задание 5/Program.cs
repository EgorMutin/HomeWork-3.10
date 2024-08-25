Console.WriteLine("Игра \"Угадай число\"");
Console.WriteLine("Введите диапазон чисел: ");

int range = int.Parse(Console.ReadLine());
Random rand = new Random();

int inumber = rand.Next(0, range);
int count = 0;
int usernumber;

while (true)
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine($"Вы вышли из игры. Загаданное число было {inumber}");
        break;
    }
    if (!int.TryParse(input, out usernumber))
    {
        Console.WriteLine("Пожалуйста, введите корректное число.");
        continue;
    }

    count++;

    if (usernumber > inumber)
    {
        Console.WriteLine($"Число {usernumber} больше загаданного числа!\n");
    }
    else if (usernumber < inumber)
    {
        Console.WriteLine($"Число {usernumber} меньше загаданного числа!\n");
    }
    else
    {
        Console.WriteLine($"Поздравляем! Вы угадали число {inumber}");
        Console.WriteLine($"Число попыток: {count}!");
        break;
    }
}

Console.WriteLine("До свидания!");
Console.ReadKey();

