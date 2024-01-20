//Complex conditions - lab, Task 010
//17.01.2024, 22:04
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