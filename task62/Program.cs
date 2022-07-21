int rows = 4;
int columns = 4;
int[,] numbers = new int[rows, columns];

int rowOffset = 0;
int columnOffset = 0;
int x = 1;
int y = 0;
int direction = 0;
int visits = numbers.GetLength(1);
    
for(int i = 0; i < numbers.Length; i++)
{
    numbers[rowOffset, columnOffset] = i + 1; 
    if( --visits == 0)
    {
        visits = numbers.GetLength(1) * (direction % 2) + numbers.GetLength(0) * ((direction + 1) % 2) - (direction/2 - 1) - 2;

        int temp = x;
        x = - y;
        y = temp;

        direction++;
    }

    columnOffset += x;
    rowOffset += y;
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
