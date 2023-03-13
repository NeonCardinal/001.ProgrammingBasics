//Conditional statements advanced - exercise, Task 005
//09.03.2023, 16:15
using System;

public class Journey
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        double price = 0.00;
        string place = string.Empty;
        string type = string.Empty;

        if(budjet <= 100)
        {
            if(season == "summer")
            {
                place = "Bulgaria";
                type = "Camp";
                price = budjet * 0.30;
            }
            else if(season == "winter")
            {
                place = "Bulgaria";
                type = "Hotel";
                price = budjet * 0.70;
            }
        }
        else if(budjet > 100 & budjet <= 1000)
        {
            if (season == "summer")
            {
                place = "Balkans";
                type = "Camp";
                price = budjet * 0.40;
            }
            else if (season == "winter")
            {
                place = "Balkans";
                type = "Hotel";
                price = budjet * 0.80;
            }
        }
        else if(budjet > 1000)
        {
            place = "Europe";
            type = "Hotel";
            price = budjet * 0.90;
        }

        Console.WriteLine($"Somewhere in {place}");
        Console.WriteLine($"{type} - {price:F2}");
    }
}