// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int num, temp, rewNum = 0, rem;
Console.WriteLine("Ведите число");
num = int.Parse(Console.ReadLine());
temp = num;
while (num > 0)
{
    rem = num % 10;
    rewNum = rewNum * 10 + rem;
    num = num / 10;
}
if (rewNum == temp)
    Console.WriteLine($"Число является полиндромом. ");
else
     Console.WriteLine($"Число не является полиндромом. ");