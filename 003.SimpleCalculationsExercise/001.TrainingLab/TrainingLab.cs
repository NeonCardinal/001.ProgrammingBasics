//Simple calculations - exercise, Task 001
//11.01.2024, 22:03
using System;

public class TrainingLab
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        length *= 100;
        width *= 100;

        int cols = ((int)width - 100) / 70;
        int rows = ((int)length / 120);
        int seats = cols * rows - 3;

        Console.WriteLine(seats);
    }
}