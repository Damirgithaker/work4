while (true)
{
    Console.Clear();
    double firstValue, secondValue;
    String action;

    Console.WriteLine("Введите число 1");
    firstValue = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите число 2");
    secondValue = double.Parse(Console.ReadLine());

    Console.WriteLine("Выберите операцию:'+' '-' '*' '/' ");
    action = Console.ReadLine();

    switch (action)
    {
        case "+":
            Console.WriteLine(firstValue + secondValue);
            break;
        case "-":
            Console.WriteLine(firstValue - secondValue);
            break;
        case "*":
            Console.WriteLine(firstValue * secondValue);
            break;
        case "/":
            if (secondValue == 0)
                Console.WriteLine("На 0 делить нельзя!!!");
            else
                Console.WriteLine(firstValue / secondValue);
            break;
        default:
            Console.WriteLine("Ошибка неизвестное действие!");
            break;
            Console.ReadLine();
    }
    Console.ReadLine();
}