//Judge: First steps in coding - more exercise, Task 001
//05.03.2024, 00:23

double b1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double h  = double.Parse(Console.ReadLine());

double area = (b1 + b2) * h / 2;

Console.WriteLine($"{area:F2}");