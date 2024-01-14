//Simple calculations - lab, Task 013
//11.01.2024, 20:58
using System;

public class CurrencyConverter
{
    static void Main()
    {
        double amount = double.Parse(Console.ReadLine());
        string curCurrency = Console.ReadLine().ToLower();
        string wantedCurrency = Console.ReadLine().ToLower();

        double leva = 0.00;
        double total = 0.00;

        if(curCurrency == "bgn")
        {
            if(wantedCurrency == "eur")
            {
                leva = amount / 1.95583;
                total = leva;
            }
            else if(wantedCurrency == "gbp")
            {
                leva = amount / 2.53405;
                total = leva;
            }
            else if(wantedCurrency == "usd")
            {
                leva = amount / 1.79549;
                total = leva;
            }
        }
        else if(curCurrency == "eur")
        {
            if(wantedCurrency == "bgn")
            {
                leva = amount * 1.95583;
                total = leva;
            }
            else if(wantedCurrency == "gbp")
            {
                leva = amount * 1.95583;
                total = leva / 2.53405;
            }
            else if(wantedCurrency == "usd")
            {
                leva = amount * 1.95583;
                total = leva / 1.79549;
            }
        }
        else if(curCurrency == "gbp")
        {
            if(wantedCurrency == "bgn")
            {
                total = amount * 2.53405;
            }
            else if(wantedCurrency == "eur")
            {
                leva = amount * 2.53405;
                total = leva / 1.95583;
            }
            else if(wantedCurrency == "usd")
            {
                leva = amount * 2.53405;
                total = leva / 1.79549;
            }
        }
        else if(curCurrency == "usd")
        {
            if(wantedCurrency == "bgn")
            {
                total = amount * 1.79549;
            }
            else if(wantedCurrency == "eur")
            {
                leva = amount * 1.79549;
                total = leva / 1.95583;
            }
            else if(wantedCurrency == "gbp")
            {
                leva = amount * 1.79549;
                total = leva / 2.53405;
            }
        }

        Console.WriteLine($"{total:F2} {wantedCurrency.ToUpper()}");
    }
}