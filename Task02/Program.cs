﻿// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// Пример
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число а = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b =  ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA>numberB)
{
    Console.Write($"Максимальное число = {numberA}");
}
else
{
    Console.Write($"Максимальное число = {numberB}");
}