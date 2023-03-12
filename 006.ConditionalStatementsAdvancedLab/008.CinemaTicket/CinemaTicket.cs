//Conditional statements advanced - lab, Task 008
//09.03.2023, 11:42
using System;

public class CinemaTicket
{
    static void Main()
    {
        string day = Console.ReadLine();

        if(day == "Monday")
        {
            Console.WriteLine(12);
        }
        else if(day == "Tuesday")
        {
            Console.WriteLine(12);
        }
        else if(day == "Wednesday")
        {
            Console.WriteLine(14);
        }
        else if(day == "Thursday")
        {
            Console.WriteLine(14);
        }
        else if(day == "Friday")
        {
            Console.WriteLine(12);
        }
        else if(day == "Saturday")
        {
            Console.WriteLine(16);
        }
        else if(day == "Sunday")
        {
            Console.WriteLine(16);
        }
    }
}