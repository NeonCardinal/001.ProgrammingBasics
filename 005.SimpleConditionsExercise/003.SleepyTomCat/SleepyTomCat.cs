//Simple conditions - exercise, Task 003
//15.01.2024, 19:32
using System;

public class SleepyTomCat
{
    static void Main()
    {
        int holydays = int.Parse(Console.ReadLine());

        int workingDays = 365 - holydays;
        int totalPlayMinutes = workingDays * 63 + holydays * 127;
        int differnce = Math.Abs(30000 - totalPlayMinutes);
        int hours = differnce / 60;
        int minutes = differnce % 60;

        if(totalPlayMinutes > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
        }
    }
}