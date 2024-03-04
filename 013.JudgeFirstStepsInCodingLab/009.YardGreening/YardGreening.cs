//Judge: First steps in coding - lab, Task 009
//04.03.2024, 23:11

double area = double.Parse(Console.ReadLine());

double discount = 0.00;

double price = area * 7.61;
discount = price * 0.18;

double total = price - discount;

Console.WriteLine($"The final price is: {total} lv.");
Console.WriteLine($"The discount is: {discount} lv.");