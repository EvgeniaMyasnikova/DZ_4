﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int square = 1;

for (int i = 1; i <= numberB; i++)
{
    square = square*numberA;
}
Console.WriteLine($"Число {numberA} в степени {numberB} = {square}");
