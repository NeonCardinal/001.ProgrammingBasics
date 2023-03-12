//Conditional statements advanced - lab, Task 003
//09.03.2023, 10:46
using System;

public class AnimalType
{
    static void Main()
    {
        string animal = Console.ReadLine();

        switch(animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}