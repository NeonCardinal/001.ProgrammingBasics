﻿//Conditional statements - lab, Task 010
//13.01.2024, 00:37
using System;

public class BetweenNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if(number < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if(number <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }
}