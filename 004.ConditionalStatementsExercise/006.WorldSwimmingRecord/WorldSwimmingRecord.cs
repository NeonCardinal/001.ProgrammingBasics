//Conditional statements - exercise, Task 006
//07.03.2023, 20:39
using System;

public class WorldSwimmingRecord
{
    static void Main()
    {
        decimal record = decimal.Parse(Console.ReadLine());
        decimal distance = decimal.Parse(Console.ReadLine());
        decimal timePerMeter = decimal.Parse(Console.ReadLine());

        decimal timeForDist = distance * timePerMeter;
        decimal addedSeconds = Math.Floor(distance / 15) * 12.5m;
        decimal total = timeForDist + addedSeconds;

        if(total < record)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {total:F2} seconds.");
        }
        else
        {
            Console.WriteLine($"No, he failed! He was {(total - record):F2} seconds slower.");
        }
    }
}