//Judge: First steps in coding - exercise, Task 003
//04.03.2024, 23:38

double deposit = double.Parse(Console.ReadLine());
int depositPeriod = int.Parse(Console.ReadLine());
double addPercent = double.Parse(Console.ReadLine());

double add = deposit * (addPercent / 100.0);
double addPerMonth = add / 12;
double total = deposit + depositPeriod * addPerMonth;

Console.WriteLine(total);