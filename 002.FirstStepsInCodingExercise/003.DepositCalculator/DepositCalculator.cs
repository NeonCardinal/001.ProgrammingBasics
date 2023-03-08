//First steps in coding - exercise, Task 003
//07.03.2023, 14:22
using System;

public class DepositCalculator
{
    static void Main()
    {
        double depositAmount = double.Parse(Console.ReadLine());
        int depositPeriod = int.Parse(Console.ReadLine());
        double yearAdd = double.Parse(Console.ReadLine());

        double add = depositAmount * (yearAdd / 100.0);
        double addPerMonth = add / 12;
        double total = depositAmount + depositPeriod * addPerMonth;

        Console.WriteLine(total);
    }
}