//Chapter Simple calculations - lab, Task 005
//27.12.2023, 17:15
using System;

public class TrapeziodArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2;

        Console.WriteLine(area);
    }
}