//Advanced loops - lab, Task 010
//24.01.2024, 00:45
using System;

public class CheckPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool prime = true;

        for(var i = 2; i < Math.Sqrt(n); i++)
        {
            if(n % i == 0)
            {
                prime = false;
                break;
            }
        }

        if(prime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
    }
}