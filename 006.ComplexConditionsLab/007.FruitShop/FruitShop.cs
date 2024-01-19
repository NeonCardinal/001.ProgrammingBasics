//Complex conditions - lab, Task 007
//17.01.2024, 21:32
using System;

public class FruitShop
{
    static void Main()
    {
        string fruit = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        double price = 0.00;

        if (day == "saturday" || day == "sunday")
        {
            if (fruit == "banana")
            {
                price = quantity * 2.70;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "apple")
            {
                price = quantity * 1.25;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "orange")
            {
                price = quantity * 0.90;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "grapefruit")
            {
                price = quantity * 1.60;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "kiwi")
            {
                price = quantity * 3.00;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "pineapple")
            {
                price = quantity * 5.60;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "grapes")
            {
                price = quantity * 4.20;
                Console.WriteLine($"{price:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if(day == "monday" || day == "thuesday" || day == "wednesday" || day == "thursday" || day == "friday")
        {
            if (fruit == "banana")
            {
                price = quantity * 2.50;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "apple")
            {
                price = quantity * 1.20;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "orange")
            {
                price = quantity * 0.85;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "grapefruit")
            {
                price = quantity * 1.45;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "kiwi")
            {
                price = quantity * 2.70;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "pineapple")
            {
                price = quantity * 5.50;
                Console.WriteLine($"{price:F2}");
            }
            else if (fruit == "grapes")
            {
                price = quantity * 3.85;
                Console.WriteLine($"{price:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}