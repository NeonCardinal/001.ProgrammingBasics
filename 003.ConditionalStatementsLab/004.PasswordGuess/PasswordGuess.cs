//Conditional statements - lab, Task 004
//07.03.2023, 15:39
using System;

public class PasswordGuess
{
    static void Main()
    {
        string password = Console.ReadLine();

        if(password == "s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}