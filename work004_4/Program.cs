int a;
int m = 2;
Console.WriteLine("Введите число диапазона");
a = int.Parse(Console.ReadLine());
while (m < a)
{
    Console.WriteLine(m);
    m = m + 2;
}