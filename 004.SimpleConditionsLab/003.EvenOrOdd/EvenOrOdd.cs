//Simple conditions - lab, Task 003
//12.01.2024, 01:34
using System;

public class EvenOrOdd
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if(n % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}