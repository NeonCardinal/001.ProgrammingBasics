//Simple conditions - lab, Task 002
//12.01.2024, 01:31
using System;

public class ExcellentOrNot
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        if(grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}