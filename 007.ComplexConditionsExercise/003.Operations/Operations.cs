//Complex conditions - exercise, Task 003
//20.01.2024, 21:10
using System;

public class Operations
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        string oper = Console.ReadLine();

        double result = 0.00;

        if(secondNumber == 0 && oper == "/" || oper == "%")
        {
            Console.WriteLine($"Cannot divide {firstNumber} by zero");
            return;
        }

        if(oper == "+")
        {
            result = firstNumber + secondNumber;

            if(result % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result} - odd");
            }
        }
        else if(oper == "-")
        {
            result = firstNumber - secondNumber;

            if (result % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result} - odd");
            }
        }
        else if(oper == "*")
        {
            result = firstNumber * secondNumber;

            if (result % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result} - odd");
            }
        }
        else if(oper == "/")
        {
            result = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result:F2}");
        }
        else if(oper == "%")
        {
            result = firstNumber % secondNumber;
            Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {result}");
        }
    }
}