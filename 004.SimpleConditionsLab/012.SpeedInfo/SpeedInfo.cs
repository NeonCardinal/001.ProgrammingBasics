//Simple conditions - lab, Task 012
//14.01.2024, 23:06
using System;

public class SpeedInfo
{
    static void Main()
    {
        double speed = double.Parse(Console.ReadLine());

        if(speed <= 10)
        {
            Console.WriteLine("slow");
        }
        else if(speed <= 50)
        {
            Console.WriteLine("average");
        }
        else if(speed <= 150)
        {
            Console.WriteLine("fast");
        }
        else if(speed <= 1000)
        {
            Console.WriteLine("ultra fast");
        }
        else
        {
            Console.WriteLine("extremely fast");
        }
    }
}