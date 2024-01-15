//Simple calculations - exercise, Task 002
//11.01.2024, 22:07
using System;

public class VegetableMarket
{
    static void Main()
    {
        double vegetablePrice = double.Parse(Console.ReadLine());
        double fruitPrice = double.Parse(Console.ReadLine());
        int vegetableWeight = int.Parse(Console.ReadLine());
        int fruitWeight = int.Parse(Console.ReadLine());

        double total = (vegetablePrice * vegetableWeight + fruitPrice * fruitWeight) / 1.94;

        Console.WriteLine(total);
    }
}