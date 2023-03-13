//Conditional statements advanced - exercise, Task 004
//09.03.2023, 14:19
using System;

public class FishingBoat
{
    static void Main()
    {
        int budjet = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int fisherCount = int.Parse(Console.ReadLine());

        double price = 0.0;
        double discount = 0.0;

        if(season == "Spring")
        {
            if(fisherCount <= 6)
            {
                discount = 3000 * 0.10;
                price = 3000 - discount;
            }
            else if(fisherCount >= 7 && fisherCount <= 11)
            {
                discount = 3000 * 0.15;
                price = 3000 - discount;
            }
            else if(fisherCount >= 12)
            {
                discount = 3000 * 0.25;
                price = 3000 - discount;
            }
        }
        else if(season == "Summer" || season == "Autumn")
        {
            if (fisherCount <= 6)
            {
                discount = 4200 * 0.10;
                price = 4200 - discount;
            }
            else if (fisherCount >= 7 && fisherCount <= 11)
            {
                discount = 4200 * 0.15;
                price = 4200 - discount;
            }
            else if (fisherCount >= 12)
            {
                discount = 4200 * 0.25;
                price = 4200 - discount;
            }
        }
        else if(season == "Winter")
        {
            if (fisherCount <= 6)
            {
                discount = 2600 * 0.10;
                price = 2600 - discount;
            }
            else if (fisherCount >= 7 && fisherCount <= 11)
            {
                discount = 2600 * 0.15;
                price = 2600 - discount;
            }
            else if (fisherCount >= 12)
            {
                discount = 2600 * 0.25;
                price = 2600 - discount;
            }
        }

        if(fisherCount % 2 == 00 && season != "Autumn")
        {
            discount = price * 0.05;
            price -= discount;
        }

        if(budjet >= price)
        {
            double leftMoney = budjet - price;

            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
        }
        else
        {
            double neededMoney = price - budjet;

            Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
        }
    }
}