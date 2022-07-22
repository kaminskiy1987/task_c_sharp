int count = getData("Введите количество строк : ");
int i = 0;
int j = 0;

for( i = 0; i < count; i++)
{
        
    for( j = 0; j < (count - i); j++)
    {
         Console.Write(" ");
    }

    for( j = 0; j <= i; j++)
    {
         Console.Write(" ");
         Console.Write(factorial(i) / (factorial(j) * factorial(i - j)));
    }
    Console.WriteLine();
    Console.WriteLine();
 }

int factorial(int number)
{
    int factorial = 1;

    for(int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
