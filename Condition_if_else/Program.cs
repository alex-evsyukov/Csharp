//Найти максимальное из 2 чисел
double a, b, max = 0;
string s;

Console.Clear();
Console.Write("Введите число a: ");
s = Console.ReadLine();
a = Convert.ToDouble(s);

Console.Write("Введите число b: ");
s = Console.ReadLine();
b = Convert.ToDouble(s);

// Не полная форма условного оператора
// if (a > b) max = a;
// if (b > a) max = b;
// if (a == b) max = a;

// Полная форма условного оператора
//if (a > b) max = a; else max = b;

if (a > b)
{
    max = a;
    System.Console.WriteLine();
}
else
{
    max = b;
}

System.Console.WriteLine($"max = {max}");