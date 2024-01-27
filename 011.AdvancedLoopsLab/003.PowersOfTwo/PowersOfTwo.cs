//Advanced loops - lab, Task 003
//23.01.2024, 22:29
using System;

public class PowersOfTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int num = 1;

        for(int i = 0; i <= n; i++)
        {
            Console.WriteLine(num);
            num = num * 2;
        }
    }
}