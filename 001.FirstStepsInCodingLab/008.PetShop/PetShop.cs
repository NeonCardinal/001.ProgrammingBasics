//First steps in coding - lab, Task 008
//07.03.2023, 13:35
using System;

public class PetShop
{
    static void Main()
    {
        int dogFoodPackets = int.Parse(Console.ReadLine());
        int catFoodPackets = int.Parse(Console.ReadLine());

        double dogFoodPrice = dogFoodPackets * 2.50;
        double catFoodPrice = catFoodPackets * 4.00;
        double total = dogFoodPrice + catFoodPrice;

        Console.WriteLine($"{total} lv.");
    }
}