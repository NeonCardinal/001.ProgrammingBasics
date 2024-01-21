//Complex conditions - lab, Task 001
//17.01.2024, 20:04
using System;

public class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string sex = Console.ReadLine();

        if(sex == "m")
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
        else if(sex == "f")
        {
            if(age < 16)
            {
                Console.WriteLine("Miss");
            }
            else
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}