//Chapter Simple calculations - lab, Task 002
//27.12.2023, 15:45
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