//Conditional statements - lab, Task 011
//13.01.2024, 00:40
using System;

public class EqualWords
{
    static void Main()
    {
        string firstWord = Console.ReadLine().ToLower();
        string secondWord = Console.ReadLine().ToLower();

        if(firstWord == secondWord)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}