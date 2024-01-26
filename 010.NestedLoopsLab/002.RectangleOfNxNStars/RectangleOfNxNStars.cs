//Nested loops - exercise, Task 002
//23.01.2024, 20:30
using System;

public class RectangleOfNxNStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', n));
        }
    }
}