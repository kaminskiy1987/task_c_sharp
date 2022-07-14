int size = getData("Введите размер массива: ");
int[] numbers = new int[size];

FillArray(numbers);
PrintArray(numbers);

int sum = 0;
   
for(int i = 0; i< numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += numbers[i];
    }
}
   
Console.WriteLine("Сумма элементов стоящих на нечетных местах " + sum);

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
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
