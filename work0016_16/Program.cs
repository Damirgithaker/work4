﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите данные координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные координаты c1: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные координаты с2: ");
int с2 = Convert.ToInt32(Console.ReadLine());


double GetDistance(int a1, int b1, int a2, int b2, int с1, int с2)
{
    double res = Math.Sqrt((a1 - a2) * (a1 - a2) + (b1 - b2) * (b1 - b2) + (с1 - с2) * (с1 - с2));
    res = Math.Round(res, 2);
    return res;
}
double result = GetDistance(x1, y1, x2, y2, c1, с2);
Console.WriteLine(result);