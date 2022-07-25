Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("\"");
Console.Write("\"");
Console.Write(getRangeNaturalNumber(n, m));
Console.Write("\"");
Console.Write("\"");

int getRangeNaturalNumber(int m, int n)
{
    int max = n;
    int min = m;

    if (max < min)
    {
        max = m;
        min = n;
    }

    if (min == max) return min;
    else
    {
        Console.Write(getRangeNaturalNumber(max - 1, min) + ", ");
        return max;
    }
}
