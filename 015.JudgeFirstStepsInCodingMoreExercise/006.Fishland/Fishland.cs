﻿//Judge: First steps in programming - more exercise, Task 006
//05.03.2024, 20:29

double priceForMackerel = double.Parse(Console.ReadLine());
double priceForSprat = double.Parse(Console.ReadLine());
double bonitoKillos = double.Parse(Console.ReadLine());
double scadKillos = double.Parse(Console.ReadLine());
double clamKillos = double.Parse(Console.ReadLine());

double bonitoPricePerKillo = priceForMackerel + priceForMackerel * 0.60;
double scadPricePerKillo = priceForSprat + priceForSprat * 0.80;

double priceForBonito = bonitoPricePerKillo * bonitoKillos;
double priceForScad = scadPricePerKillo * scadKillos;
double priceForClam = clamKillos * 7.50;

double totalMoney = priceForBonito + priceForScad + priceForClam;

Console.WriteLine($"{totalMoney:F2}");