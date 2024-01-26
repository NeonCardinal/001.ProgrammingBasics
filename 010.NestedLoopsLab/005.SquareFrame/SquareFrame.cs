//Nested loops - lab, Task 005
//23.01.2024, 20:40
using System;

public class SquareFrame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write("+");
        for(int i = 0; i < n -2; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("+");

        for(int i = 0; i < n - 2; i++)
        {
            Console.Write("|");
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine("|");
        }

        Console.Write("+");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("+");
    }
}