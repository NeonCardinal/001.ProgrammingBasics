//Loops - lab, Task 005
//21.01.2024, 21:53
using System;

public class MaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int max = int.MinValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number > max)
            {
                max = number;
            }
        }

        Console.WriteLine(max);
    }
}