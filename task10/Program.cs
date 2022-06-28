Console.WriteLine("Задача по нахождению второй цифры в трехзначном числе");
Console.WriteLine("------------------------------");
Console.WriteLine("Введите трехзначное число");
int tripleDidits = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------");

int secondDigitInNumber = (tripleDidits % 100 - tripleDidits % 10 ) / 10;
Console.WriteLine("Вторая цифра в числе: " + secondDigitInNumber);
