//Nested loops - lab, Task 006
//23.01.2024, 20:45
using System;

public class RhombusOfStars
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int row = 1; row <= inputNumber; row++)
        {
            for (int col = 0; col < inputNumber - row; col++)
            {
                Console.Write(" ");
            }

            for (int col = 0; col < row; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }

        for (int row = 1; row <= inputNumber; row++)
        {
            for (int col = 0; col < row - 1; col++)
            {
                Console.Write(" ");
            }

            for (int col = 0; col < inputNumber - row; col++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }
    }
}