//Judge: First steps in coding - more exercise, Task 005
//05.03.2024, 20:27

double w = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double widthInCm = w * 100;
double heightInCm = (h * 100) - 100;

int row = (int)(widthInCm / 120);
int col = (int)(heightInCm / 70);
int result = row * col - 3;

Console.WriteLine(result);