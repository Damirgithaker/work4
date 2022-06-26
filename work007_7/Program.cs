//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int rndnum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100,999 => {rndnum}");
int RemSecDig(int rndnum)
{
    int Digit2 = rndnum % 100;
    int result = Digit2 / 10;
    return result;
}


if (rndnum > 99 && rndnum < 1000)
{
    Console.WriteLine(RemSecDig(rndnum));
}
else
{
    Console.WriteLine("Введено некорректное значение");
}

Console.ReadLine();









