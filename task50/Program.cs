int rows = getData("Введите количество строк: ");
int columns = getData("Введите количество столбцов: ");

int positionNumberInRow = getData("Введите номер позиции в строке: ");
int positionNumberInColumn = getData("Введите номер позиции в столбце: ");

int[,] numbers = new int[rows, columns];
int value = 0;

fillMatrix(numbers);
printMatrix(numbers);

if (positionNumberInRow > 9 || positionNumberInRow > numbers.GetLength(0) || positionNumberInColumn > 9 || positionNumberInColumn > numbers.GetLength(1))
{
    Console.WriteLine("Такого числа нет");
}
else 
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j <  numbers.GetLength(1); j++)
        {
            if(numbers[(positionNumberInRow - 1), (positionNumberInColumn - 1)] == numbers[i, j])
            {
                value = numbers[i,j];   
            }
        }
    }
    Console.WriteLine("Значение элемента : " + value);
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
            numbers[i, j] = new Random().Next(10, 99);
        }
    }
}

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
