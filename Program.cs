int  OutputNumbers(int m, int n)
{
    if (m== n)
        return m;
    return  OutputNumbers(m, n-1)+n;
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(OutputNumbers(m,n));