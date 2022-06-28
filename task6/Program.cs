Console.WriteLine("Задача по определению четности числа");
Console.WriteLine("------------------------------");
Console.WriteLine("Введите число");
int digit1 = Convert.ToInt32(Console.ReadLine());

if (digit1 % 2 == 0)
{
    Console.WriteLine(digit1 + " - четное число");
}
else
{
    Console.WriteLine(digit1 + " - нечетное число");
}