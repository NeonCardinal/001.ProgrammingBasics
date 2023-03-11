//Conditional statements - more exercise, Task 004
//08.03.2023, 18:36
using System;

public class TransportPrice
{
    static void Main()
    {
        int kilometers = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();
        double totalPrice = 0.0;

        if(kilometers < 20)
        {
            if(dayTime == "day")
            {
                totalPrice = kilometers * 0.79 + 0.70;
            }
            else if(dayTime == "night")
            {
                totalPrice = kilometers * 0.90 + 0.70;
            }
        }
        else if(kilometers >= 20 && kilometers < 100)
        {
            totalPrice = kilometers * 0.09;
        }
        else if(kilometers >= 100)
        {
            totalPrice = kilometers * 0.06;
        }

        Console.WriteLine($"{totalPrice:F2}");
    }
}