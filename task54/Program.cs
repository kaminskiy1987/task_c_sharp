int rows = getData("Введите количество строк: ");
int columns = getData("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

fillMatrix(numbers);
printMatrix(numbers);

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        for(int k = 0; k < numbers.GetLength(1); k++)
        {
            if(numbers[i, j] >= numbers[i, k]) continue;

            int temp = numbers[i, j];
            numbers[i, j] = numbers[i, k];
            numbers[i, k] = temp;
        }
    }
}

printMatrix(numbers);
   
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
