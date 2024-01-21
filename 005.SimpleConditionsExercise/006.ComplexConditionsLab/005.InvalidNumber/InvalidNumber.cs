//Complex conditions - lab, Task 005
//17.01.2024, 20:52
using System;

public class InvalidNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool inRange = (number >= 100 && number <= 200) || number == 0;

        if(!inRange)
        {
            Console.WriteLine("invalid");
        }
    }
}