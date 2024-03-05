//Judge: First steps in coding - more exercise, Task 008
//05.03.2024, 20:34

double r = double.Parse(Console.ReadLine());

double area = Math.PI * r * r;
double perimeter = 2 * Math.PI * r;

Console.WriteLine($"{area:F2}");
Console.WriteLine($"{perimeter:F2}");