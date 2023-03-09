//Conditional statements - lab, Task 001
//07.03.2023, 15:30
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