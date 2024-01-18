//Simple conditions - exercise, Task 005
//15.01.2024, 19:50
using System;

public class Firm
{
    static void Main()
    {
        int projectHours = int.Parse(Console.ReadLine());
        int availableDays = int.Parse(Console.ReadLine());
        int overtimeWorkers = int.Parse(Console.ReadLine());

        var workDays = availableDays * 0.90;
        var overtime = overtimeWorkers * 2 * availableDays;
        var workHours = Math.Floor(workDays * 8 + overtime);

        if (workHours < projectHours)
        {
            Console.WriteLine($"Yes!{projectHours - workHours} hours left.");
        }
        else
        {
            Console.WriteLine($"Not enough time!{Math.Abs(projectHours - workHours)} hours needed.");
        }
    }
}