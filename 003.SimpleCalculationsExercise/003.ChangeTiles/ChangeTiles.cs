//Simple calculations - exercise, Task 003
//11.01.2024, 22:11
using System;

public class ChangeTiles
{
    static void Main()
    {
        int area = int.Parse(Console.ReadLine());
        double wTile = double.Parse(Console.ReadLine());
        double lTile = double.Parse(Console.ReadLine());
        double wBench = double.Parse(Console.ReadLine());
        double lBench = double.Parse(Console.ReadLine());

        double benchArea = wBench * lBench;
        double tileArea = wTile * lTile;
        double areaWOBench = (area * area) - benchArea;
        double neededArea = areaWOBench / tileArea;
        double neededTime = neededArea * 0.2;

        Console.WriteLine(neededArea);
        Console.WriteLine(neededTime);
    }
}