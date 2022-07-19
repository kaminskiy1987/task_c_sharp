int rows = getData("Введите количество строк: ");
int columns = getData("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

fillMatrix(numbers);
printMatrix(numbers);

for(int i = 0; i < numbers.GetLength(1); i++)
{
    int sum = 0;

    for(int j = 0; j < numbers.GetLength(0); j++)
    {
        sum += numbers[j, i];
    }
      
    double average = Convert.ToDouble(sum) / numbers.GetLength(0);
    int columnNumber = i + 1;

    Console.WriteLine("Номер столбца: " + columnNumber + " ; Среднее арифметическое =  " +  average);
}
   
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
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
