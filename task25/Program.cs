int number = getData("Введите число : ");
int level = getData("Введите степень : ");
int result = 1;

for(int i = 0; i < level; i++)
{
    result *= number;
}

Console.WriteLine("{0} ^ {1} = {2}", number, level, result );

int getData(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}
