//Conditional statements advanced - lab, Task 007
//09.03.2023, 11:38
using System;
using System.Threading.Channels;

public class WorkingHours
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();

        if(day == "Sunday")
        {
            Console.WriteLine("closed");
        }
        else
        {
            if(hour >= 10 && hour <= 18)
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}