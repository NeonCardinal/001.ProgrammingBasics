//Conditional statements advanced - lab, Task 006
//09.03.2023, 11:04
using System;

public class NumberInRange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool inRange = (number >= -100 && number <= 100) && number != 0;

        if(inRange)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}