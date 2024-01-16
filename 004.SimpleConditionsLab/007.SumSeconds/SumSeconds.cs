//Simple conditions - lab, Task 007
//12.01.2024, 23:50
using System;

public class SumSeconds
{
    static void Main()
    {
        int firstCompetitor = int.Parse(Console.ReadLine());
        int secondCompetitor = int.Parse(Console.ReadLine());
        int thirdCompetitor = int.Parse(Console.ReadLine());

        int minutes = 0;
        int seconds = firstCompetitor + secondCompetitor + thirdCompetitor;

        if(seconds >= 60)
        {
            minutes++;
            seconds -= 60;
        }
        if(seconds >= 60)
        {
            minutes++;
            seconds -= 60;
        }

        if(seconds < 10)
        {
            Console.WriteLine($"{minutes}:0{seconds}");
        }
        else
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}