﻿//Conditional statements advanced - lab, Task 002
//09.03.2023, 10:42
using System;

public class WeekendOrWorkingDay
{
    static void Main()
    {
        string day = Console.ReadLine();

        switch(day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                Console.WriteLine("Working day");
                break;
            case "Saturday":
            case "Sunday":
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}