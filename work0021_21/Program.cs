// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
//int[] array = new int[5];
int[] array = { 6, 7, 19, 345, 3 };
var rnd = new Random();
int index = 0;
// while (index < array.Length)
// {
//     array[index] = rnd.Next(0, 1000);
//     Console.Write($"{array[index]}  ");
//     index++;
// }
Console.WriteLine();
string CheckNumber(int[] arr, int num)
{
    string res = "нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) res = "Да";
    }
    return res;
}
string result = CheckNumber(array, number);
Console.WriteLine(result);