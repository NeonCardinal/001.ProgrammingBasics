//First steps in coding - exercise, Task 004
//07.03.2023, 14:27
using System;

public class VacationBooksList
{
    static void Main()
    {
        int pagesCount = int.Parse(Console.ReadLine());
        int pagesPerHour = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int totalTimePerBook = pagesCount / pagesPerHour;
        int neededHours = totalTimePerBook / days;

        Console.WriteLine(neededHours);
    }
}