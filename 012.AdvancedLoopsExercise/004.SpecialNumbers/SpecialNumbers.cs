﻿//Advanced loops, Task 004
//24.01.2024, 21:07
using System;

public class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int p = 1; p <= 9; p++)
                    {
                        if (n % i == 0 && n % j == 0 && n % k == 0 && n % p == 0)
                        {
                            Console.Write($"{i}{j}{k}{p} ");
                        }
                    }
                }
            }
        }
    }
}