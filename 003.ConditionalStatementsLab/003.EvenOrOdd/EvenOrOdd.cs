//Conditional statements - lab, Task 003
//07.03.2023, 15:36
using System;

public class EvenOrOdd
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}