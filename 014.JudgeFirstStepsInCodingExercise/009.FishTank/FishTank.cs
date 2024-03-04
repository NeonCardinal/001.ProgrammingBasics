//Judge: First steps in coding - exercise, Task 009
//05.03.2024, 00:00

int len = int.Parse(Console.ReadLine());
int widht = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double volume = (len * widht * height) * 0.001;
double takenArea = volume * (percent / 100.0);
double total = volume - takenArea;

Console.WriteLine(total);