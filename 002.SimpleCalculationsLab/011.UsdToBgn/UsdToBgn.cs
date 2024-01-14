//Simple calculations - lab, Task 011,
//11.01.2023, 20:55
using System;

public class UsdToBgn
{
    static void Main()
    {
        double usd = double.Parse(Console.ReadLine());

        double leva = usd * 1.79549;

        Console.WriteLine($"{leva:F2} BGN");
    }
}