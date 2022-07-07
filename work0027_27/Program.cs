// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 89, 6] -> 85

int[] array = new int[6];
var rnd = new Random();
int index = 0;

while (index < array.Length)
{
    array[index] = rnd.Next(-10, 10);
    Console.Write($"{array[index]} ");
    index++;
}
int sumPos = 0;
for (int i = 0; i < array.Length + 1; i++)
{

    if (i! % 2 != 0)
    {
        sumPos = sumPos + array[i - 1];
    }
}
Console.WriteLine();
Console.WriteLine($" Сумма не четных позиций массива =  {sumPos}");