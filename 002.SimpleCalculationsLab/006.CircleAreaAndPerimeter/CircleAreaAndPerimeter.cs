//Chapter Simple calculations - lab, Task 006
//27.12.2023, 17:29
using System;

public class CircleAreaAndPerimeter
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}