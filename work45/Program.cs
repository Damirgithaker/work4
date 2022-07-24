
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет



int[,] myArray = new int[3, 5];
Random rnd = new Random();

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = rnd.Next(0, 10);
        Console.Write(myArray[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}

void CreateArrayRndDouble(int rows, int col)
{

    if (rows > (myArray.GetLength(0)) || col > (myArray.GetLength(1)))
    {
        Console.WriteLine("Индексы вышли за границы!");
    }
    else
    {

        Console.Write(myArray[rows - 1, col - 1]);
    }
Console.WriteLine();
}
Console.Write("Введите позицию строки - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позтцию столбца - ");
int col = Convert.ToInt32(Console.ReadLine());
CreateArrayRndDouble(rows, col);

