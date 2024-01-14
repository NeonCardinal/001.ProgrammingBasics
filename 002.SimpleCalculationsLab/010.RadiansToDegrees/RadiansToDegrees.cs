//Simple calculations - lab, Task 010
//11.01.2024, 20:33
using System;

public class RadiansToDegrees
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());

        double deg = Math.Round(rad * 180 / Math.PI);

        Console.WriteLine(deg);
    }
}