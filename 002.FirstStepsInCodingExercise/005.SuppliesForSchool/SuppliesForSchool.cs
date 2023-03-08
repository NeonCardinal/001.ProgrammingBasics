//First steps in coding - exercise, Task 005
//07.03.2023, 14:33
using System;

public class SuppliesForSchool
{
    static void Main()
    {
        int penPackets = int.Parse(Console.ReadLine());
        int markersPackets = int.Parse(Console.ReadLine());
        int litters = int.Parse(Console.ReadLine());
        int discountPercent = int.Parse(Console.ReadLine());

        double penPrice = penPackets * 5.80;
        double markerPrice = markersPackets * 7.20;
        double litterPrice = litters * 1.20;
        double priceForAll = penPrice + markerPrice + litterPrice;
        double discount = priceForAll * (discountPercent / 100.0);
        double total = priceForAll - discount;

        Console.WriteLine(total);
    }
}