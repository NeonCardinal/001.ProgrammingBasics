//Conditional statements advanced - lab, Task 004
//09.03.2023, 10:49
using System;

public class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if(gender == "m")
        {
            if(age < 16)
            {
                Console.WriteLine("Master");
            }
            else if(age >= 16)
            {
                Console.WriteLine("Mr.");
            }
        }
        else if(gender == "f")
        {
            if(age < 16)
            {
                Console.WriteLine("Miss");
            }
            else if(age >= 16)
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}