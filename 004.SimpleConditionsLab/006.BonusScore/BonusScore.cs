//Simple conditions - lab, Task 006
//12.01.2024, 01:47
using System;

public class BonusScore
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        double score = 0;
        
        if(number <= 100)
        {
            score += 5;
        }
        else if(number <= 1000)
        {
            score += number * 0.20;
        }
        else
        {
            score += number * 0.10;
        }

        if(number % 2 == 0)
        {
            score += 1;
        }
        else if(number % 10 == 5)
        {
            score += 2;
        }

        Console.WriteLine(score);
        Console.WriteLine(score + number);
    }
}