//Conditional statements advanced - more exercise, Task 006
//10.03.2023, 13:44
using System;

public class TruckDriver
{
    static void Main()
    {
        string season = Console.ReadLine();
        double kilometers = double.Parse(Console.ReadLine());
        double income = 0.0;

        if (kilometers <= 5000)
        {
            if (season == "Spring" || season == "Autumn")
            {
                income = kilometers * 0.75;
            }
            else if (season == "Summer")
            {
                income = kilometers * 0.90;
            }
            else if (season == "Winter")
            {
                income = kilometers * 1.05;
            }
        }
        else if (kilometers > 5000 && kilometers <= 10000)
        {
            if (season == "Spring" || season == "Autumn")
            {
                income = kilometers * 0.95;
            }
            else if (season == "Summer")
            {
                income = kilometers * 1.10;
            }
            else if (season == "Winter")
            {
                income = kilometers * 1.25;
            }
        }
        else if (kilometers > 10000 && kilometers <= 20000)
        {
            income = kilometers * 1.45;
        }

        income *= 4;
        double tax = income * 0.10;
        income -= tax;

        Console.WriteLine($"{income:F2}");
    }
}
