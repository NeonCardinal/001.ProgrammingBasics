//Loops - exercise, Task 002
//23.01.2024, 19:15
using System;

public class SmartLilly
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingmachinePrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());

        int toyCnt = 0;
        double sum = 0.00;
        double birthDayMoney = 0.00;

        for(int i = 1; i <= age; i++)
        {
            if(i % 2 == 0)
            {
                sum += 10;
                birthDayMoney += sum;
            }
            else
            {
                toyCnt++;
            }
        }

        birthDayMoney -= age / 2;
        double toyIncome = toyCnt * (toyPrice * 1.00);
        double totalIncome = birthDayMoney + toyIncome;

        if(toyIncome >= washingmachinePrice)
        {
            double leftMoney = totalIncome - washingmachinePrice;

            Console.WriteLine($"Yes! {leftMoney:F2}");
        }
        else
        {
            double neededMoney = washingmachinePrice - totalIncome;

            Console.WriteLine($"No! {neededMoney:F2}");
        }
    }
}
