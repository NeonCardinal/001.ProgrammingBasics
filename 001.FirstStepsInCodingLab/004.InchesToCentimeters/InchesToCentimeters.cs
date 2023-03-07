//First steps in coding - lab, Task 004
//07.03.2023, 13:24
using System;

public class InchesToCentimeters
{
    static void Main()
    {
        double inches = double.Parse(Console.ReadLine());

        double centimeters = inches * 2.54;

        Console.WriteLine(centimeters);
    }
}