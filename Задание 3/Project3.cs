public class Project3
{
    public void Run()
    {


        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool divisor = false;
        int i = 2;

        while (i < number)
        {
            if (number % i == 0)
            {
                divisor = true;
                break;
            }
            i++;
        }

        if (!divisor && number > 1)
        {
            Console.WriteLine($"Число {number} является простым числом");
        }
        else
        {
            Console.WriteLine($"Число {number} не является простым числом");
        }

        Console.ReadKey();
    }
}
