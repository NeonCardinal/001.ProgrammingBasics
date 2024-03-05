//Judge: First steps in coding - more exercise, Task 010
//05.03.2024, 20:45

double deg = double.Parse(Console.ReadLine());

if(deg >= 25.00 && deg <= 35.00)
{
    Console.WriteLine("Hot");
}
else if(deg >= 20.1 && deg <= 25.9)
{
    Console.WriteLine("Warm");
}
else if(deg >= 15.00 && deg <= 20.00)
{
    Console.WriteLine("Mild");
}
else if(deg >= 12.00 && deg <= 14.9)
{
    Console.WriteLine("Cool");
}
else if(deg >= 5.00 & deg <= 11.9)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("unknown");
}