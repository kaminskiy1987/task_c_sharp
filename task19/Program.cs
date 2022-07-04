int fiveDigitNumber = getData("Введите пятизначное число: ");

Console.WriteLine("Палиндром -  " + isPalindrom(fiveDigitNumber));

int getData(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

bool isPalindrom(int number)
{
    if(number < 9999 || number > 99999)
    {
        return false;
    }

    int invertedNumber = 0;
    int temp = number;

    while(temp != 0)
    {
        invertedNumber = invertedNumber * 10 + temp % 10;
        temp = temp / 10; 
    }

    return (invertedNumber == number);
}
