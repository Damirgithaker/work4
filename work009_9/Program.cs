// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру дня недели");
int num = int.Parse(Console.ReadLine());;
if (num > 0 && num < 8)
    if (num == 1) Console.WriteLine("Не выходной!!");
if (num == 2) Console.WriteLine("Не выходной!!");
if (num == 3) Console.WriteLine("Не выходной!!");
if (num == 4) Console.WriteLine("Не выходной!!");
if (num == 5) Console.WriteLine("Не выходной!!");
if (num == 6) Console.WriteLine("ВЫХОДНОЙ!!");
if (num == 7) Console.WriteLine("ВЫХОДНОЙ!!");

