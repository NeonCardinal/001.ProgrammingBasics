//Conditional statements advanced - more exercise, Task 010
//10.03.2023, 13:53
using System;

public class MultiplyByTwo
{
    static void Main()
    {
        while (true)
        {
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Negative number!");
                break;
            }

            double result = number * 2;

            Console.WriteLine($"Result: {result:F2}");
        }
    }
}