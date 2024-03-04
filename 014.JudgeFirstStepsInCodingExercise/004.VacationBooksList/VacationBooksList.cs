//Judge: First steps in coding - exercise, Task 004
//04.03.2024, 23:44

int pagesCount = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int totalTimePerBook = pagesCount / pagesPerHour;
int neededHours = totalTimePerBook / days;

Console.WriteLine(neededHours);