//Judge: First steps in coding - exercise, Task 005
//04.03.2024, 23:47

int pensCnt = int.Parse(Console.ReadLine());
int markersCnt = int.Parse(Console.ReadLine());
int litters = int.Parse(Console.ReadLine());
int discountPercent = int.Parse(Console.ReadLine());

double pensPrice = pensCnt * 5.80;
double markersPrice = markersCnt * 7.20;
double littersPrice = litters * 1.20;
double total = pensPrice + markersPrice + littersPrice;
double discount = total * (discountPercent / 100.00);
total -= discount;

Console.WriteLine(total);

