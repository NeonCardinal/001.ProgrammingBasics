﻿//Loops - lab, Task 006
//21.01.2024, 22:52
using System;

public class MinNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number < min)
            {
                min = number;
            }
        }

        Console.WriteLine(min);
    }
}