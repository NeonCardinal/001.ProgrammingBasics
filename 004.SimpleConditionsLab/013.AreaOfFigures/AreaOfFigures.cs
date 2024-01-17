//Simple conditions - lab, Task 013
//14.01.2023, 23:13
using System;

public class AreaOfFigures
{
    static void Main()
    {
        string figure = Console.ReadLine();

        if(figure == "square")
        {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(a * a);
        }
        else if(figure == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a * b);
        }
        else if(figure == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI * r * r);
        }
        else if(figure == "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(a * h / 2);
        }
    }
}