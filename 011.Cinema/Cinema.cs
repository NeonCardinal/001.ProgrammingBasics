//Complex conditions - lab, Task 011
//17.01.2024, 22:37
using System;

public class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        double price = 0.00;

        if(type == "premiere")
        {
            price = rows * cols * 12.00;
            Console.WriteLine($"{price:F2} leva");
        }
        else if(type == "normal")
        {
            price = rows * cols * 7.50;
            Console.WriteLine($"{price:F2} leva");
        }
        else if(type == "discount")
        {
            price = rows * cols * 5.00;
            Console.WriteLine($"{price:F2} leva");
        }
    }
}