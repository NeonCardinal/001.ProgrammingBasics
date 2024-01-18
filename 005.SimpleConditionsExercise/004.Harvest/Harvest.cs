//Simple conditions - exercise, Task 004
//15.01.2024, 19:44
using System;

public class Harvest
{
    static void Main()
    {
        int area = int.Parse(Console.ReadLine());
        double grapePerSquare = double.Parse(Console.ReadLine());
        int neededVine = int.Parse(Console.ReadLine());
        int workersCount = int.Parse(Console.ReadLine());

        double grapeKg = area * grapePerSquare;
        double vine = (grapeKg * 0.40) / 2.5;

        if (vine >= neededVine)
        {
            double leftVine = vine - neededVine;
            Console.WriteLine($"Good harvest this year! Total wine: {vine} liters.");
            Console.WriteLine($"{Math.Ceiling(leftVine)} liters left -> {Math.Ceiling(leftVine / workersCount)} liters per person.");
        }
        else
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededVine - vine)} liters wine needed.");
        }
    }
}