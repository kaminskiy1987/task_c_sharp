int rows = getData("Введите количество строк: ");
int columns = getData("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

fillMatrix(numbers);
Console.WriteLine();
printMatrix(numbers);

int minValueInRow = 0;
int minValueInColumn = 0;

for(int i = 0; i < numbers.GetLength(0); i++)
{ 
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        if (numbers[i, j] < numbers[minValueInRow, minValueInColumn])
        {
            minValueInRow = i;
            minValueInColumn = j;
        } 
    }
}

int rowOffset = 0;
int columnOffset = 0;

int[,] truncatedMatrix = new int[rows-1, columns-1];

for(int i = 0; i < truncatedMatrix.GetLength(0); i++)
{
    if(i >= minValueInRow)
    {
        rowOffset = i + 1;
    }
    else
    {
        rowOffset = i;
    }

    for(int j =0; j < truncatedMatrix.GetLength(1); j++)
    {
        if(j >= minValueInColumn)
        {
           columnOffset = j + 1;
        }
        else
        {
            columnOffset = j;
        }

        truncatedMatrix[i, j] = numbers[rowOffset, columnOffset];
        Console.Write(" {0} ", truncatedMatrix[i, j]);
    }
    Console.WriteLine();
}
 Console.WriteLine();

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
            numbers[i, j] = new Random().Next(10, 99);
        }
    }
}

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
