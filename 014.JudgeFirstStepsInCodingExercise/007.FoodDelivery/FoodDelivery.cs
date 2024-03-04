//Judge: First steps in coding - exercise, Task 007
//04.03.2024, 23:56

int chicken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int vegetable = int.Parse(Console.ReadLine());

double chickenPrice = chicken * 10.35;
double fishPrice = fish * 12.40;
double vegetablePrice = vegetable * 8.15;
double foodPrice = chickenPrice + fishPrice + vegetablePrice;
double desertPrice = foodPrice * 0.20;
double total = foodPrice + desertPrice + 2.50;

Console.WriteLine(total);