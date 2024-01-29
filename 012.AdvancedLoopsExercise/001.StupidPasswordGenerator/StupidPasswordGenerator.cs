//Advanced loops - exercise, Task 001
//24.01.2024, 19:05
using System;

public class StupidPasswordGenerator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= n; j++)
            {
                for(char ch1 = 'a'; ch1 <= 'a' + l; ch1++)
                {
                    for(char ch2 = 'a'; ch2 <= 'a' + l; ch2++)
                    {
                        for(int k = Math.Max(i, j) + 1; k <= n; k++)
                        {
                            Console.Write($"{i}{j}{ch1}{ch2}{k} ");
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}