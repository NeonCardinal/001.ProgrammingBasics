//Loops - lab, Task 002
//21.01.2024, 21:19
using System;

public class NumbersEndingInSeven
{
    static void Main()
    {
        for(int i = 1; i <= 1000; i++)
        {
            if(i % 10 == 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}