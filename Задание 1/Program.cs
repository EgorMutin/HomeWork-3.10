using System.ComponentModel.Design;

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным числом");
}
else
{
    Console.WriteLine($"Число {number} является нечетным числом");
}
Console.ReadKey();