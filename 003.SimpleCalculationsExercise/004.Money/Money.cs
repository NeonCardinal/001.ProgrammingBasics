//Simple calculations - exercise, Task 004
//12.01.2024, 00:26
using System;

public class Money
{
    static void Main()
    {
        int bitcoins = int.Parse(Console.ReadLine());
        decimal yoani = decimal.Parse(Console.ReadLine());
        decimal commision = decimal.Parse(Console.ReadLine()) / 100.0m;

        decimal leva = bitcoins * 1168m;
        decimal dollars = yoani * 0.15m;
        //decimal dollarsToLeva = dollars * 1.76m;
        leva += (dollars * 1.76m);
        decimal euro = leva / 1.95m;
        decimal comm = euro * commision;
        decimal total = euro - comm;

        Console.WriteLine(total);
    }
}