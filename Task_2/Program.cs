﻿// Напишите программу, которая принимает на вход принимает два числа и выдает,
//  какое число большее, а какое меньшее

Console.Clear();
Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int y = int.Parse(Console.ReadLine()!);
if (y > x)
{
    Console.WriteLine($"max={y}"); 
}
else
{
    Console.WriteLine($"max={x}"); 
}  