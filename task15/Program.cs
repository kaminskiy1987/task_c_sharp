Console.WriteLine("Задача по определению выходного дня");
Console.WriteLine("------------------------------");
Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit > 7 || digit == 0)
{
    Console.WriteLine("Неправильный ввод");
}
else if(digit < 6)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Выходной день");
}