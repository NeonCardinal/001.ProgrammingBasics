//First steps in coding - exercise, Task 007
//07.03.2023, 14:48
using System;

public class FoodDelivery
{
    static void Main()
    {
        int chicken = int.Parse(Console.ReadLine());
        int fish = int.Parse(Console.ReadLine());
        int vegetable = int.Parse(Console.ReadLine());

        double chickenPrice = chicken * 10.35;
        double fishPrice = fish * 12.40;
        double vegetablePrice = vegetable * 8.15;
        double foodPrice = chickenPrice + fishPrice + vegetablePrice;
        double desertPrice = foodPrice * 0.20;
        double total = foodPrice + desertPrice + 2.50;

        Console.WriteLine(total);
    }
}