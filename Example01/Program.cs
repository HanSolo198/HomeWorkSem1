﻿//  Задача 2: Напишите программу,
//  которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

//  a = 5;  b = 7  -> max = 7
//  a = 2   b = 10 -> max = 10
//  a = -9  b = -3 -> max = -3

Console.Clear();
Console.Write("Введите А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("А больше В");
}
else if (numA < numB)
{
    Console.WriteLine("А меньше В");
}
else 
{
    Console.WriteLine("Оба числа равны");
}
    Console.ReadKey();