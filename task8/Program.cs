Console.WriteLine("Задача по нахождению четных чисел");
Console.WriteLine("------------------------------");
Console.WriteLine("Введите число");
int endRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------");

int startRange = 1;
int i = startRange;

while(i <= endRange)
{
    if (i % 2 == 0)
    {
        Console.Write( " " + i);
    }

    i++;
}
