//Simple calculations - lab, Task 009
//03.01.2024, 10:46
using System;

public class CelsiusToFahrenheit
{
    static void Main()
    {
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(fahrenheit);
    }
}