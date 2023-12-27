//Chapter First steps in programming, Task 004
//24.12.2023, 20:02
using System;

public class TriangleOfStars
{
    static void Main()
    {
        for(int i = 1; i <= 10; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}