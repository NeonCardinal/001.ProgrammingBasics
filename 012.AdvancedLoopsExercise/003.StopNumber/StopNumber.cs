//Advanced loops - exercise, Task 003
//24.01.2024, 21:01
using System;

public class StopNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());

        for(int i = m; i >= n; i--)
        {
            if(i % 2 == 0 && i % 3 == 0)
            {
                if(i == stop)
                {
                    break;
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}