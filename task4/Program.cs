Console.WriteLine("Задача по сравнению трех чисел");
Console.WriteLine("------------------------------");
Console.WriteLine("Введите первое число");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int digit2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int digit3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = digit1;

if (digit2 > digit1)
{
    maxNumber = digit2;
}

if(digit3 > maxNumber)
{
    maxNumber = digit3;
}

Console.WriteLine("Максимальное число = " + maxNumber);