//Advanced loops - lab, Task 005
//24.01.2024, 00:09
using System;

public class SequenceTwoKPlusOne
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int num = 1;

        while(num <= number)
        {
            Console.WriteLine(num);
            num = 2 * num + 1;
        }
    }
}