// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] array = { 3, 7, 2.2, 2, 7.8 };
double arrayMax = array[0];
double arrayMin = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > arrayMax)
    {
        arrayMax = array[i];
    }
    if (array[i] < arrayMin)
    {
        arrayMin = array[i];
    }
}
double result = arrayMax - arrayMin;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом =  {result}");
