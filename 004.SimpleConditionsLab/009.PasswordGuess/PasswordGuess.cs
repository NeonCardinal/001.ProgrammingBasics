//Simple conditions - lab, Task 009
//13.01.2024, 00:08
using System;

public class PasswordGuess
{
    static void Main()
    {
        string pass = Console.ReadLine();
        string password = "s3cr3t!P@ssw0rd";

        if(pass == password)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}