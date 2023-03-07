//First steps in coding - lab, Task 006
//07.03.2023, 13:28
using System;

public class ConcatenateData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();

        Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
    }
}