//Complex conditions - exercise, Task 002
//18.01.2023, 23:34
using System;

public class Trip
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        double price = 0.00;
        string place = "";
        string type = "";

        if(budjet <= 100)
        {
            place = "Bulgaria";

            if(season == "summer")
            {
                price = budjet * 0.30;
                type = "Camp";
            }
            else if(season == "winter")
            {
                price = budjet * 0.80;
                type = "Hotel";
            }
        }
        else if(budjet <= 1000)
        {
            place = "Balcans";

            if (season == "summer")
            {
                price = budjet * 0.40;
                type = "Camp";
            }
            else if (season == "winter")
            {
                price = budjet * 0.80;
                type = "Hotel";
            }
        }
        else
        {
            place = "Europe";
            price = budjet * 0.90;
            type = "Hotel";
        }

        if(!string.IsNullOrEmpty(place))
        {
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{type} - {price:F2}");
        }
    }
}