//Nested loops - lab, Task 003
//23.01.2024, 20:33
using System;

public class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}