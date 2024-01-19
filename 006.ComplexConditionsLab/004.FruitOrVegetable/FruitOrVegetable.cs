//Complex conditions - lab, Task 004
//17.01.2024, 20:48
using System;

public class FruitOrVegetable
{
    static void Main()
    {
        string str = Console.ReadLine();

        if(str == "banana" || str == "apple" || str == "kiwi" || str == "cherry" || str == "lemon"
            || str == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if(str == "tomato" || str == "cucumber" || str == "pepper" || str == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}