int number = getData("Введите число : ");

int sum = 0;

while(number != 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine("Сумма чисел = " + sum);

int getData(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}
