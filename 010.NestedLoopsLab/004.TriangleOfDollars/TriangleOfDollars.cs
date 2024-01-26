//Nested loops - lab, Task 004
//23.01.2024, 20:36
using System;

public class TriangleOfDollars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.Write("$");
            for (int j = 0; j < i; j++)
            {
                Console.Write("$");
            }

            Console.WriteLine();
        }
    }
}