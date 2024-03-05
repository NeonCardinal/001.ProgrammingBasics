//Judge: First steps in coding - exercise, Task 004
//05.03.2024, 00:57

double priceForVegetables = double.Parse(Console.ReadLine());
double priceForFruits = double.Parse(Console.ReadLine());
int vegetablesWeight = int.Parse(Console.ReadLine());
int fruitsWeight = int.Parse(Console.ReadLine());

double total = priceForVegetables * vegetablesWeight + priceForFruits *  fruitsWeight;
total /= 1.94;

Console.WriteLine($"{total:F2}");