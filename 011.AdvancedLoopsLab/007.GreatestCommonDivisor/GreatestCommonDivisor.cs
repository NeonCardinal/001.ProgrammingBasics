//Advanced loops - lab, Task 007
//24.01.2024, 00:18
using System;

public class GreatestCommonDivisor
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while(b != 0)
        {
            var oldB = b;
            b = a % b;
            a = oldB;
        }

        Console.WriteLine($"GCD = {a}");
    }
}