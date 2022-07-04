int x1 = getData("Введите X1: ");
int y1 = getData("Введите Y1: ");
int z1 = getData("Введите Z1: ");

int x2 = getData("Введите X2: ");
int y2 = getData("Введите Y2: ");
int z2 = getData("Введите Z2: ");

int distanceX = x1 - x2;
int distanceY = y1 - y2;
int distanceZ = z1 - z2;

double distance = Math.Sqrt(getQuadro(distanceX) + getQuadro(distanceY) + getQuadro(distanceZ));
Console.WriteLine(distance);

int getData(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

int getQuadro(int number)
{
return number * number;
}