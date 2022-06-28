Console.WriteLine("Задача по нахождению третьей цифры в числе");
Console.WriteLine("------------------------------");
Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------");

int thirdDiditInNumber = 0;

if (digit > 99)
{
    thirdDiditInNumber = (digit / 100) % 10; 
    Console.Write( "Третья цифра в числе: " + thirdDiditInNumber); 
}
else 
{
    Console.Write( "Третьей цифры нет"); 
}
