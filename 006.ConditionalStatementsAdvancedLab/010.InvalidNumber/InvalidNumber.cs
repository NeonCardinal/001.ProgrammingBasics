//Conditional statements advanced - lab, Task 010
//09.03.2023, 11:50
using System;

public class InvalidNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isInvalid = (number < 100 || number > 200) && number != 0;

        if(isInvalid)
        {
            Console.WriteLine("invalid");
        }
    }
}