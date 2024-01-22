//Complex conditions - exercise, Task 004
//20.01.2024, 21:39
using System;

public class MatchTickets
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string ticketsType = Console.ReadLine().ToLower();
        int peopleCount = int.Parse(Console.ReadLine());

        double ticketsPrice = 0.00;
        double transportPrice = 0.00;

        if(ticketsType == "normal")
        {
            ticketsPrice = peopleCount * 249.99;

            if(peopleCount >= 1 && peopleCount <= 4)
            {
                transportPrice = budjet * 0.75;
            }
            else if(peopleCount >= 5 && peopleCount <= 9)
            {
                transportPrice = budjet * 0.60;
            }
            else if(peopleCount >= 10 && peopleCount <= 24)
            {
                transportPrice = budjet * 0.50;
            }
            else if(peopleCount >= 25 && peopleCount <= 49)
            {
                transportPrice = budjet * 0.40;
            }
            else if(peopleCount >= 50)
            {
                transportPrice = budjet * 0.25;
            }
        }
        else if(ticketsType == "vip")
        {
            ticketsPrice = peopleCount * 499.99;

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                transportPrice = budjet * 0.75;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                transportPrice = budjet * 0.60;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                transportPrice = budjet * 0.50;
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                transportPrice = budjet * 0.40;
            }
            else if (peopleCount >= 50)
            {
                transportPrice = budjet * 0.25;
            }
        }

        double neededMoney = ticketsPrice + transportPrice;

        if(neededMoney <= budjet)
        {
            double temp = budjet - neededMoney;
            Console.WriteLine($"Yes! You have {temp:F2} leva left.");
        }
        else
        {
            double temp = neededMoney - budjet;
            Console.WriteLine($"Not enough money! You need {temp:F2} leva");
        }
    }
}