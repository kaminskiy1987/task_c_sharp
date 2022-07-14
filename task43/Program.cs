double b1 = getData("Введите b1: ");
double k1 = getData("Введите k1: ");

double b2 = getData("Введите b2: ");
double k2 = getData("Введите k2: ");

double x = getX(b1, k1, b2, k2);
Console.WriteLine("Значение Х = " + x);

double y  = getY(b1, k1, x);
Console.WriteLine("Значение Y = " + y);

Console.WriteLine("(" + x + ";" + y + ")");

double getX(double b1, double k1, double b2, double k2)
{
    return ((b2-b1)/(k1 -k2));
}

double getY(double b1, double k1, double x)
{
    return (k1 * x + b1);
}

int getData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
