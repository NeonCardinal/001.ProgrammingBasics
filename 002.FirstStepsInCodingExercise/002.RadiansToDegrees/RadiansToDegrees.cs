//First steps in coding - exercise, Task 002
//07.03.2023, 14:19
using System;

public class RadiansToDegrees
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());

        double deg = rad * 180 / Math.PI;

        Console.WriteLine(deg);
    }
}