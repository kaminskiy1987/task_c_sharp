int rows = getData("Введите количество строк: ");
int columns = getData("Введите количество столбцов: ");
double[,] numbers = new double[rows, columns];

fillMatrix(numbers);
printMatrix(numbers);

void printMatrix(double[,] matrix)
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

void fillMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        }
    }
}

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
