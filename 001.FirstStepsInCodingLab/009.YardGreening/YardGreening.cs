//First steps in coding - lab, Task 009
//07.03.2023, 13:39
using System;

public class YardGreening
{
    static void Main()
    {
        double area = double.Parse(Console.ReadLine());

        double price = area * 7.61;
        double discount = price * 0.18;
        double total = price - discount;

        Console.WriteLine($"The final price is: {total} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}