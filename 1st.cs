double s = 0,x = 0;
int i;
int k = 1;
Console.WriteLine("Введите значение x (Градусы):");
if (Double.TryParse(Console.ReadLine(), out x)) {
    for (i = 1; i <= 9; i++)
    {
        s = s + (Math.Cos(i*x))/(Math.Pow(x,i-1));
    }
}
Console.WriteLine(s);

s = 0;

for (i = 1; i <= 6; i++)
{
    k = 1;
    for (int j = 1; j <= i; j++)
    {
        k *= j;
    }
    s = s + (Math.Pow(-1, i) * Math.Pow(5, i)) / k;
}

Console.WriteLine(s);
