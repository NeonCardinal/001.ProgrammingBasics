//Fist steps in coding - exercise, Task 001
//07.03.2023, 14:17
using System;

public class UsdToBgn
{
    static void Main()
    {
        double usd = double.Parse(Console.ReadLine());

        double bgn = usd * 1.79549;

        Console.WriteLine(bgn);
    }
}