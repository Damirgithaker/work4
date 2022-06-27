// 1. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndnum = new Random().Next();
Console.WriteLine($"Случайное число из диапазона int => {rndnum}");
int RemSecDig(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Нет третьей цифры");
    }
    while (num > 999)
    {
        num = num / 10;
       Console.WriteLine(num);
    }
    int result= num%10;
    return result;
}
int res = RemSecDig(rndnum);
Console.Write($" Третье цифра числа =>{rndnum} == {res}");