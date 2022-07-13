// 1. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
 
int rndnum = new Random(). Next(100,1000);
Console.WriteLine($"Случайное число из диапазона 100,999 => {rndnum}");
int RemSecDig(int num) 
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}
int res = RemSecDig(rndnum);
Console.WriteLine(res);