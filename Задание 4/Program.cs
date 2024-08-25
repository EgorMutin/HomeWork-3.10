{
    Console.WriteLine("Введите длину последовательности: ");
    int value = Convert.ToInt32(Console.ReadLine());
    if (value <= 0)
    {
        Console.WriteLine("Введите корректное число длины последовательности");
        Console.ReadLine(); return;

    }


    int min = int.MaxValue;
    int i = 0;


    for (i = 0; i < value; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент последовательности");
        int A = Convert.ToInt32(Console.ReadLine());

        if (A < min)
        {
            min = A;
        }
    }
    Console.WriteLine($"\nЭлемент {min} минимальный в последовательности");

    Console.ReadKey();
}