Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Функция Аккермана равна: " + calculateFunction(m, n));


int calculateFunction(int m, int n)
{
    if( m == 0) return n + 1;
    if( n == 0 && m != 0) return calculateFunction(m - 1, 1);
    return calculateFunction( m - 1,calculateFunction(m, n - 1 )); 
}
