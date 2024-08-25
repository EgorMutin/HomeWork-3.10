public class Project2
{
    public void Run()
    {


        Console.WriteLine("Добро пожаловать в игру \"21\"!\n");
        Console.Write("Введите количество ваших карт (от 2 до 36): ");

        int cardValue;


        while (!int.TryParse(Console.ReadLine(), out cardValue) || cardValue > 36 || cardValue <= 1)
        {
            Console.Write("Введите корректное количество карт (в колоде всего 36 карт): ");
        }


        int totalSum = 0;
        int cardNominal = 0;

        for (int i = 0; i < cardValue; i++)
        {
            Console.WriteLine($"Введите номинал {i + 1}-й карты (число или буква): ");
            string card = Console.ReadLine().ToUpper();
            switch (card)
            {
                case "T":
                case "J":
                case "Q":
                case "K":

                    totalSum += 10; break;
                default:



                    if (int.TryParse(card, out cardNominal) && cardNominal >= 2 && cardNominal <= 10)
                    {
                        totalSum += cardNominal;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный номинал карты. Считаем её как 0.");
                    }

                    break;
            }



        }
        Console.WriteLine($"Сумма карт: {totalSum}");


        Console.ReadKey();
    }
}