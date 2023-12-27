//Chapter First steps in programming, Task 006
//27.12.2023, 13:09
using System;

public class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));

        for(int i = 0; i < n - 2; i++)
        {
            Console.Write("*");
            Console.Write(new string(' ', n - 2));
            Console.WriteLine("*");
        }

        Console.WriteLine(new string('*', n));
    }
}