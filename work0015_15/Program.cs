// Напишите программу которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N.


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

    for (int i = 1; i <= num; i++)
{
    Console.WriteLine($" квадрат числа | {i} = {i * i, 2}|");
}


