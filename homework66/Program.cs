// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Clear();
// Console.WriteLine("Введите число м: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
//  int temporly=m;
// if (m > n) 
// {
//   m = n; 
//   n = temporly;
// }

// void SumNaturalNum(int m, int n, int summ)
// {
//   summ = summ + n;
//   if (n <= m)
//   {
//     Console.Write($"Сумма элементов= {summ} ");
//     return;
//   }
//   SumNaturalNum(m, n - 1, summ);
// }
// int finalResult = SumNaturalNum(m, n);
// Console.WriteLine($"Сумма натурвльных чисел от {m}  до {n} =: {finalResult}");
// //  (N2 –М2 +М+N)/2,








Console.Clear();
Console.WriteLine("Введите число м: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}