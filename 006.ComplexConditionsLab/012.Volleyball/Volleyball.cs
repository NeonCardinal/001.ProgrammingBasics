//Complex conditions - lab, Task 012
//17.01.2024, 22:59
using System;

public class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weenedsInHometown = int.Parse(Console.ReadLine());

        double sofiaWeekends = (48 - weenedsInHometown) * 3.0 / 4;
        double gamesHolidays = holidays * 2.0 / 3;
        double totalGames = sofiaWeekends + weenedsInHometown + gamesHolidays;

        if (yearType == "normal")
        {
            Console.WriteLine(Math.Truncate(totalGames));
        }
        else if (yearType == "leap")
        {
            double LeapYear = totalGames * 15 / 100;
            Console.WriteLine(Math.Truncate(totalGames + LeapYear));
        }
    }
}