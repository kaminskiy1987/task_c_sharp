int size = getData("Введите размер массива: ");
int[] numbers = new int[size];

FillArray(numbers);
PrintArray(numbers);

int evenNumbersCount = 0;
   
for(int i = 0; i< numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenNumbersCount++;
    }
}
   
Console.WriteLine("Количество четных чиcел " + evenNumbersCount);

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
