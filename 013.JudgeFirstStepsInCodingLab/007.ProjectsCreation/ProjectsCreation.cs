//Judge: First steps in coding - lab, Task 007
//04.03.2024, 23:03

string name = Console.ReadLine();
int projectsCnt = int.Parse(Console.ReadLine());

int neededHours = projectsCnt * 3;

Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {projectsCnt} project/s.");