//Advanced loops - exercise, Task 002
//24.01.2024, 19:43
using System;

public class MagicCombination
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 9; i++)
        {
            for(int j = 1; j <= 9; j++)
            {
                for(int k = 1; k <= 9; k++)
                {
                    for(int p = 1; p <= 9; p++)
                    {
                        for(int u = 1; u <= 9; u++)
                        {
                            for(int h = 1; h <= 9; h++)
                            {
                                if(i * j * k * p * u * h == number)
                                {
                                    Console.WriteLine($"{i}{j}{k}{p}{u}{h}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}