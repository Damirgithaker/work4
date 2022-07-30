// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();
Console.WriteLine("Введите число м: ");
int num = int.Parse(Console.ReadLine());
NaturalDecreasing(num);

void NaturalDecreasing(int numN)
{
    if (numN >= 1 )
    {
        
        Console.Write($"{numN}");
        NaturalDecreasing( numN - 1);
    }
}

