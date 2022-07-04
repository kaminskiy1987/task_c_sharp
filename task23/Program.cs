int number = getData("Введите число: ");
int startRange = 1;
int result = 0;

while(startRange <= number)
{
    result = getCube(startRange);

    startRange++;

    Console.Write(result + " ");
  
}

int getData(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

int getCube(int number)
{
return number * number * number;
}
