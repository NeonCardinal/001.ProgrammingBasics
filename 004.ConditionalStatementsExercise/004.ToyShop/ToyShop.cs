//Conditional statements - exercise, Task 004
//07.03.2023, 17:52
using System;

public class ToyShop
{
    static void Main()
    {
        double vacantionPrice = double.Parse(Console.ReadLine());
        int puzzleCount = int.Parse(Console.ReadLine());
        int muppetCount = int.Parse(Console.ReadLine());
        int teddyBearCount = int.Parse(Console.ReadLine());
        int minionCount = int.Parse(Console.ReadLine());
        int truckCount = int.Parse(Console.ReadLine());
        int toysCount = 0;

        double puzzlePrice = puzzleCount * 2.60;
        double muppetPrice = muppetCount * 3.00;
        double teddyBearPrice = teddyBearCount * 4.10;
        double minionPrice = minionCount * 8.20;
        double truckPrice = truckCount * 2.00;
        double priceForAll = puzzlePrice + muppetPrice + teddyBearPrice + minionPrice + truckPrice;

        toysCount = puzzleCount + muppetCount + teddyBearCount + minionCount + truckCount;

        if(toysCount >= 50)
        {
            double discount = priceForAll * 0.25;
            priceForAll -= discount;
        }

        double rent = priceForAll * 0.10;
        priceForAll -= rent;

        if(priceForAll >= vacantionPrice)
        {
            Console.WriteLine($"Yes! {(priceForAll - vacantionPrice):F2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {(vacantionPrice - priceForAll):F2} lv needed.");
        }
    }
}