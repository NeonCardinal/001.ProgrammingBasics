//Judge: First steps in coding - exercise, Task 008
//04.03.2024, 23:58

int pricePerYear = int.Parse(Console.ReadLine());

double priceForShoes = pricePerYear * 0.60;
double pricePerEquipe = priceForShoes * 0.80;
double priceForBall = pricePerEquipe / 4;
double priceForAcc = priceForBall / 5;
double total = pricePerYear + priceForShoes + pricePerEquipe + priceForBall + priceForAcc;

Console.WriteLine(total);