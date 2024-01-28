//Advanced loops - lab, Task 009
//24.01.2024, 00:40
using System;

public class SumDigits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        do
        {
            sum = sum + (n % 10);
            n = n / 10;
        }
        while (n > 0);

        Console.WriteLine(sum);
    }
}