//Simple calculations - exercise, Task 005
//12.01.2024, 00:51
using System;

public class DailyEarnings
{
    static void Main()
    {
        int workingDays = int.Parse(Console.ReadLine());
        double moneyPerDay = double.Parse(Console.ReadLine());
        double dollarValue = double.Parse(Console.ReadLine());

        double monthSalary = workingDays * moneyPerDay;
        double bonus = monthSalary * 2.5;
        double yearSalary = 12 * monthSalary + bonus;
        double vat = yearSalary * 0.25;
        yearSalary -= vat;
        double clearnPerDay = (yearSalary / 365) * dollarValue;

        Console.WriteLine($"{clearnPerDay:F2}");
    }
}