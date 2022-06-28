Console.WriteLine("Задача по сравнению двух чисел");
Console.WriteLine("------------------------------");
Console.WriteLine("Введите первое число");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int digit2 = Convert.ToInt32(Console.ReadLine());

bool compare1 = digit1 > digit2;
bool compare2 = digit1 == digit2;
bool compare3 = digit1 < digit2;

if (compare1)
{
    Console.WriteLine("Большее число = " + digit1 + "; Меньшее число = " + digit2);
}
else if(compare2)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("Большее число = " + digit2 + "; Меньшее число = " + digit1);
}