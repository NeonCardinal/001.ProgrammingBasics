//Conditional statements advanced - exercise, Task 003
//09.03.2023, 14:04
using System;

public class NewHouse
{
    static void Main()
    {
        string flowers = Console.ReadLine();
        int flowersCount = int.Parse(Console.ReadLine());
        double budjet = double.Parse(Console.ReadLine());

        double price = 0.0;
        double discount = 0.0;
        double add = 0.0;

        if(flowers == "Roses")
        {
            if(flowersCount > 80)
            {
                price = flowersCount * 5.00;
                discount = price * 0.10;
                price -= discount;
            }
            else
            {
                price = flowersCount * 5.00;
            }
        }
        else if(flowers == "Dahlias")
        {
            if(flowersCount > 90)
            {
                price = flowersCount * 3.80;
                discount = price * 0.15;
                price -= discount;
            }
            else
            {
                price = flowersCount * 3.80;
            }
        }
        else if(flowers == "Tulips")
        {
            if(flowersCount > 80)
            {
                price = flowersCount * 2.80;
                discount = price * 0.15;
                price -= discount;
            }
            else
            {
                price = flowersCount * 2.80;
            }
        }
        else if(flowers == "Narcissus")
        {
            if(flowersCount < 120)
            {
                price = flowersCount * 3.00;
                add = price * 0.15;
                price += add;
            }
            else
            {
                price = flowersCount * 3.00;
            }
        }
        else if(flowers == "Gladiolus")
        {
            if(flowersCount < 80)
            {
                price = flowersCount * 2.50;
                add = price * 0.20;
                price += add;
            }
            else
            {
                price = flowersCount * 2.50;
            }
        }

        if(price <= budjet)
        {
            double leftMoney = budjet - price;

            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {leftMoney:F2} leva left.");
        }
        else
        {
            double neededMoney = price - budjet;

            Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
        }
    }
}