//Advanced loops - lab, Task 001
//23.01.2024, 22:25
using System;

public class NumberWithStepThree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}