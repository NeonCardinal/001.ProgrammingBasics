//Conditional statements - exercise, Task 007
//08.03.2023, 10:03
using System;

public class Shopping
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        int vgaCount = int.Parse(Console.ReadLine());
        int cpuCount = int.Parse(Console.ReadLine());
        int ramCount = int.Parse(Console.ReadLine());

        double vgaPrice = vgaCount * 250.0;
        double cpuUnitPrice = vgaPrice * 0.35;
        double cpuPrice = cpuCount * cpuUnitPrice;
        double ramUnitPrice = vgaPrice * 0.10;
        double ramPrice = ramCount * ramUnitPrice;
        double priceForAll = vgaPrice + cpuPrice + ramPrice;

        if(vgaCount > cpuCount)
        {
            double discount = priceForAll * 0.15;
            priceForAll -= discount;
        }

        if(budjet >= priceForAll)
        {
            double leftMoney = budjet - priceForAll;
            Console.WriteLine($"You have {leftMoney:F2} leva left!");
        }
        else
        {
            double neededMoney = priceForAll - budjet;
            Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
        }
    }
}