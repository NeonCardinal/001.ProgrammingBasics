﻿//Complex conditions - lab, Task 006
//17.01.2024, 20:56
using System;

public class PointOnRectangleBorder
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if((x == x1 || x == x2) && (y >= y1) && (y <= y2) || (y == y1 || y == y2) && (x >= x1) && (x <= x2))
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside/Outside");
        }
    }
}