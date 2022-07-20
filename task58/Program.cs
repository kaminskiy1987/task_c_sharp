int rows1 = getData("Введите количество строк у первой матрицы: ");
int columns1 = getData("Введите количество столбцов у первой матрицы: ");

int rows2 = getData("Введите количество строк у второй матрицы: ");
int columns2 = getData("Введите количество столбцов у второй матрицы: ");

int[,] numbers1 = new int[rows1, columns1];
int[,] numbers2 = new int[rows2, columns2];

Console.WriteLine();
fillMatrix(numbers1);
Console.WriteLine("Матрица1");
Console.WriteLine("--------");
printMatrix(numbers1);

fillMatrix(numbers2);
Console.WriteLine("Матрица2");
Console.WriteLine("--------");
printMatrix(numbers2);

int[,] matrix = mult(numbers1, numbers2);
Console.WriteLine("Матрица1 * Матрица2");
Console.WriteLine("-------------------");
printMatrix(matrix);

int[,] mult( int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
       for(int j = 0; j < matrix2.GetLength(0); j++)
        {
            for(int k = 0; k < matrix2.GetLength(1); k++)
            {
                newMatrix[i, k] += matrix1[i, j] * matrix2[j, k]; 
            }
        }   
    }
    return newMatrix;
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
            numbers1[i, j] = new Random().Next(1, 50);
            numbers2[i, j] = new Random().Next(1, 50);
        }
    }
}

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
