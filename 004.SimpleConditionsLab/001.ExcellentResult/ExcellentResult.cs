//Simple conditions - lab, Task 001
//12.01.2024, Task 001
using System;

public class ExcellentResult
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        if(grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }
}