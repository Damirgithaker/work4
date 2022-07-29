// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка





void CreateArray(int[,] myArray)
{
Random rnd = new Random();
for (int i = 0; i < 5; i++) 
{
    Console.Write("\n{0}: ", i);
    for (int j = 0; j < 5; j++) 
    {
        myArray[i, j] = rnd.Next(1, 9);
        Console.Write("{0}  ", myArray[i, j]);
    }
}
}

int[,] myArray = new int[5, 5];
int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
CreateArray(myArray);

for (int i = 0; i < 5; i++) 
{
    Sum2 = 0;
    for (int j = 0; j < 5; j++) 
    { Sum2 += myArray[i, j]; }
    if (Sum2 < Sum1)
    { Sum = Sum2; Row = i; }
    Sum1 = Sum2;
}
Console.WriteLine("\n\t Наименьшаяя сумма = {0}", Sum);
Console.WriteLine("\n\t Номер строки = {0}", Row);

Console.ReadKey();