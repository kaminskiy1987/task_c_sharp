int size = getData("Введите размерность массива : ");
int maxSize = 8;

int arraySize = getSize(size, maxSize);

int[] array = new int[arraySize];

Console.WriteLine("Введите массив чисел: ");

for(int i = 0; i < array.Length; i++)
{
array[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArray(array);

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write( array[i] + " ");
}
Console.WriteLine();
}

int getSize(int number, int maxSize)
{
    if ( number > maxSize)
{
    Console.WriteLine("Максимальный размер массива равен = 8");
    return -1;
}
else
{
    return size;
}
}
