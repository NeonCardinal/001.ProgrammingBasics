//Judge: First steps in coding - exercise, Task 006
//04.03.2024, 23:55

int nylon = int.Parse(Console.ReadLine());
int dye = int.Parse(Console.ReadLine());
int litters = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonPrice = (nylon + 2) * 1.50;
double extraDye = dye * 0.10;
double dyePrice = (dye + extraDye) * 14.50;
double litterPrice = litters * 5.00;
double priceForAll = nylonPrice + dyePrice + litterPrice + 0.40;
double workersPrice = priceForAll * 0.30;
double total = priceForAll + (workersPrice * hours);

Console.WriteLine(total);