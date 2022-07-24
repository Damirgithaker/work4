// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество стоблцов ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = Math.Round((rnd.NextDouble() * (100 - 4) + 4), 2);
        Console.Write($"{myArray[i, j]} ");
        
    }
Console.WriteLine();
}
