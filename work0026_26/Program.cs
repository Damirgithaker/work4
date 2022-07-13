// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] array = new int[6];
var rnd = new Random();
int index = 0;

while (index < array.Length)
{
    array[index] = rnd.Next(100, 1000);
    Console.Write($"{array[index]} ");
    index++;
}
int count = 0;

for (int i = 0; i < array.Length; i++)
{

    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
    else
    {
        index++;
    }

}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: ==> {count} ");