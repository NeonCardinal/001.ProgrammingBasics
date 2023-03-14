//Conditional statements advanced - more exercise, Task 005
//10.03.2023, 10:54
using System;

public class Vacation
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        double price = 0.00;
        string location = string.Empty;
        string place = string.Empty;

        if(budjet <= 1000)
        {
            place = "Camp";

            if(season == "Summer")
            {
                location = "Alaska";
                price = budjet * 0.65;
            }
            else if(season == "Winter")
            {
                location = "Morocco";
                price = budjet * 0.45;
            }
        }
        else if(budjet > 1000 && budjet <= 3000)
        {
            place = "Hut";

            if (season == "Summer")
            {
                location = "Alaska";
                price = budjet * 0.80;
            }
            else if (season == "Winter")
            {
                location = "Morocco";
                price = budjet * 0.60;
            }
        }
        else if(budjet > 3000)
        {
            place = "Hotel";

            if (season == "Summer")
            {
                location = "Alaska";
                price = budjet * 0.90;
            }
            else if (season == "Winter")
            {
                location = "Morocco";
                price = budjet * 0.90;
            }
        }

        Console.WriteLine($"{location} - {place} - {price:F2}");
    }
}