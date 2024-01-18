//Simple conditions - exercise, Task 001
//14.01.2024, 23:53
using System;

public class TransportPrice
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();

        double price = 0.00;
        double total = 0.00;

        if(time == "day")
        {
            price = 0.79;
        }
        else
        {
            price = 0.90;
        }

        if(n < 20)
        {
            total = n * price + 0.70;
        }
        else if(n < 100)
        {
            price = 0.09;
            total = n * price;
        }
        else
        {
            price = 0.06;
            total = n * price;
        }

        Console.WriteLine(total);
    }
}