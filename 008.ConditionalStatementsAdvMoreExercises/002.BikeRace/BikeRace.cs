//Conditional statements advanced - more exercise, Task 002
//10.03.2023, 08:17
using System;

public class BikeRace
{
    static void Main()
    {
        int juniorCount = int.Parse(Console.ReadLine());
        int seniorCount = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();

        double income = 0.00;

        if(type == "trail")
        {
            income = juniorCount * 5.50 + seniorCount * 7.00;
        }
        else if(type == "cross-country")
        {
            income = juniorCount * 8.00 + seniorCount * 9.50;
        }
        else if(type == "downhill")
        {
            income = juniorCount * 12.25 + seniorCount * 13.75;
        }
        else if(type == "road")
        {
            income = juniorCount * 20.00 + seniorCount * 21.50;
        }

        double discount = 0.00;

        if(juniorCount + seniorCount >= 50 && type == "cross-country")
        {
            discount = income * 0.25;
            income -= discount;
        }

        double tax = income * 0.05;
        income -= tax;

        Console.WriteLine($"{income:F2}");
    }
}