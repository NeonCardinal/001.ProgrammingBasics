//Advanced loops - lab, Task 008
//24.01.2024, 00:37
using System;

public class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int fact = 1;

        do
        {
            fact *= n;
            n--;
        }
        while (n > 1);

        Console.WriteLine(fact);
    }
}