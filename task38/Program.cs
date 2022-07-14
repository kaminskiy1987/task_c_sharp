int size = getData("Введите размер массива: ");
double[] numbers = new double[size];

FillArray(numbers);
PrintArray(numbers);

double min = int.MaxValue;
double max = int.MinValue;
   
for(int i = 0; i< numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine("Max = " + max);
Console.WriteLine("Min = " + min);

double difference = (max - min);   
Console.WriteLine("Разность = " + difference);

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(-10,10) + new Random().NextDouble();
    }
}

void PrintArray(double[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
