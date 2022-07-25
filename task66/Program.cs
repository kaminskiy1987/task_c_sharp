Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Сумма чисел в диапазоне : " + getSumNaturalNumber(m, n));


int getSumNaturalNumber(int m, int n)
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
        return max + getSumNaturalNumber(max - 1, min);
    }
}
