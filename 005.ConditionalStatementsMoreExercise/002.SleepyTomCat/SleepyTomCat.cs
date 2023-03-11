//Conditional statements - more exercise, Task 002
//08.03.2023, 18:14
using System;

public class SleepyTomCat
{
    static void Main()
    {
        int holyDays = int.Parse(Console.ReadLine());

        int workingMinutes = (365 - holyDays) * 63;
        int holyMinutes = holyDays * 127;
        int totalTime = workingMinutes + holyMinutes;
        int playTime = Math.Abs(30000 - totalTime);
        int hours = playTime / 60;
        int minutes = playTime % 60;

        if(totalTime <= 30000)
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
        }
        else
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
        }
    }
}