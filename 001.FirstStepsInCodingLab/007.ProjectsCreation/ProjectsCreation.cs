//First steps in coding - lab, Task 007
//07.03.2023, 13:32
using System;

public class ProjectsCreation
{
    static void Main()
    {
        string name = Console.ReadLine();
        int projects = int.Parse(Console.ReadLine());

        int neededHours = projects * 3;

        Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {projects} project/s.");
    }
}