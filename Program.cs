int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (m < 0 || n < 0)
{
    Console.Write("Оба числа должны быть неотрицательными! \nВведите 1-ое число: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2-ое число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(AkkermanFunction(m, n));