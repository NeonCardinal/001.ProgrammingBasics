//Advanced loops - lab, Task 006
//24.01.2024, 00:14
using System;

public class NumberInRange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        while(number < 1 || number > 100)
        {
            Console.WriteLine("Ivalid number!");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(number);
    }
}