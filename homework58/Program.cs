// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] m1 = new int[3, 3];
Random rnd = new Random();
for (int i = 0; i < m1.GetLength(0); i++)
{
    Console.Write("\n{0}: ", i);
    for (int j = 0; j < m1.GetLength(1); j++)
    {
        m1[i, j] = rnd.Next(1, 9);
        Console.Write("{0}  ", m1[i, j]);
    }
}
Console.WriteLine();

int[,] m2 = new int[3, 3];
Random rnd1 = new Random();
for (int i = 0; i < m2.GetLength(0); i++)
{
    Console.Write("\n{0}: ", i);
    for (int j = 0; j < m2.GetLength(1); j++)
    {
        m2[i, j] = rnd.Next(1, 9);
        Console.Write("{0}  ", m2[i, j]);
    }
}
Console.WriteLine();

void ProizvedM1M2(int[,]m1, int[,]m2)
{
for (int i = 0; i < m1.GetLength(0); i++)
{
    Console.Write("\n{0}: ", i);
    for (int j = 0; j < m1.GetLength(1); j++)
    {
        m1[i, j] = m1[i, j] * m2[i, j];
        Console.Write("{0}  ",m1[i, j]);
    }
    Console.WriteLine("\n");
}
 Console.ReadKey();
}
ProizvedM1M2(m1,m2);
