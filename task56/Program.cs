int rows = getData("Введите количество строк: ");
int columns = getData("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

fillMatrix(numbers);
printMatrix(numbers);

int min = int.MaxValue;
int line = 0;

for(int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;

    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers[i, j];
    }
    Console.WriteLine($"Строка {i + 1} : {sum}");

        if (sum < min)
        {
            min = sum;
            line = i;
        } 
}

Console.WriteLine();
Console.WriteLine($"Наименьшая сумма : {min}");

void printMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void fillMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 50);
        }
    }
}

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
