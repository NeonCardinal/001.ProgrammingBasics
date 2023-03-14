//Conditional statements advanced - more exercise, Task 001
//09.03.2023, 18:18
using System;

public class MatchTickets
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int peopleCount = int.Parse(Console.ReadLine());

        double transportPrice = 0.00;

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

        double ticketPrice = 0.00;

        if(category == "Normal")
        {
            ticketPrice = peopleCount * 249.99;
        }
        else if(category == "VIP")
        {
            ticketPrice = peopleCount * 499.99;
        }

        double total = transportPrice + ticketPrice;

        if(total <= budjet)
        {
            double leftMoney = budjet - total;

            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
        }
        else
        {
            double neededMoney = total - budjet;

            Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
        }
    }
}