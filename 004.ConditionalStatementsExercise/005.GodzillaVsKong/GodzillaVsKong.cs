//Conditional statements - exercise, Task 005
//07.03.2023, 18:03
using System;

public class GodzillaVsKong
{
    static void Main()
    {
        double movieBudget = double.Parse(Console.ReadLine());
        int statistCount = int.Parse(Console.ReadLine());
        double clothPrice = double.Parse(Console.ReadLine());

        double decorPrice = movieBudget * 0.10;
        double statistPrice = 0.0;

        if(statistCount > 150)
        {
            double discount = clothPrice * 0.10;
            statistPrice = statistCount * (clothPrice - discount);
        }
        else
        {
            statistPrice = statistCount * clothPrice;
        }

        double total = decorPrice + statistPrice;

        if(total <= movieBudget)
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {(movieBudget - total):F2} leva left.");
        }
        else
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {(total - movieBudget):F2} leva more.");
        }
    }
}