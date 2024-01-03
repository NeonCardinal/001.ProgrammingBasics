//Chapter Simple calculations - lab, Task 004
//27.12.2023, 17:09
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