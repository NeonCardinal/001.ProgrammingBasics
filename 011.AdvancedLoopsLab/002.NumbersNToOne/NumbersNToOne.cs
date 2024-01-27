//Advanced loops - lab, Task 002
//23.01.2024, 22:27
using System;

public class NumbersNToOne
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}