
int[] array = new int[12];
var rnd = new Random();
int index = 0;
while (index < array.Length)
{
    array[index] = rnd.Next(-9, 10);
    Console.Write($"{array[index]}");
    index++;
}

int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        sumNeg = sumNeg + array[i];
    }
    else
    {
        sumPos = sumPos + array[i];

    }
}
Console.WriteLine();
Console.WriteLine($"Суммв положительных чисел - {sumPos}");
Console.WriteLine($"Сумма отрицательных чисел - {sumNeg}");




int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;
    while (index < array.Length)
    {
        array[index] = rnd.Next(-9, 10);
        index++;
    }
    return array;
}

int[] GetSumNegPosElen(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg = sumNeg + arr[i];
        }
        else
        {
            sumPos = sumPos + arr[i];

        }
    }
    return new int[](sumPos, sumNeg);
}
void PrintArray ()
{
  for (int i = 0; i < arr.length; i++)
  {
    if (i==0) Console.Write("[");
    if(i<array.Length -1) Console.WriteLine(array[i]+ "+");
    else Console.WriteLine(array[i])
  } 

}

int[]array = CreateArrayRndInt(12);
int[]getSumNegPosElen = GetSumNegPosElen(array);