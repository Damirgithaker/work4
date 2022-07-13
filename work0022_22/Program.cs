// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int[] array = { 1, 2, 3, 4, 5 };
int[] GetProizved(int[] arr);
{
    if (array.Length % 2 +1)

    int[] newArr = new int[];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return newArr;
}
int[] newArry = GetProizved(array);
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.WriteLine(array[i] + "+");
        else Console.WriteLine(arr[i]);
    }

}
PrintArray(newArry);
