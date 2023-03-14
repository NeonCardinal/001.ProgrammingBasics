//Conditional statements advanced - more exercise, Task 004
//10.03.2023, 10:44
using System;

public class CarToGo
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        double price = 0.00;
        string carClass = string.Empty;
        string carType = string.Empty;

        if(budjet <= 100)
        {
            carClass = "Economy class";

            if(season == "Summer")
            {
                carType = "Cabrio";
                price = budjet * 0.35;
            }
            else if(season == "Winter")
            {
                carType = "Jeep";
                price = budjet * 0.65;
            }
        }
        else if(budjet > 100 && budjet <= 500)
        {
            carClass = "Compact class";

            if(season == "Summer")
            {
                carType = "Cabrio";
                price = budjet * 0.45;
            }
            else if(season == "Winter")
            {
                carType = "Jeep";
                price = budjet * 0.80;
            }
        }
        else if(budjet > 500)
        {
            carClass = "Luxury class";
            carType = "Jeep";
            price = budjet * 0.90;
        }

        Console.WriteLine(carClass);
        Console.WriteLine($"{carType} - {price:F2}");
    }
}