// See https://aka.ms/new-console-template for more information
// С клавиатуры вводятся два числа. Подсчитатьих сумму
int a = 1;
int b = 2;
int sum = 0;
string s;
Console.Clear();
Console.Write("Введите число a: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);
Console.Write("Введите число b: ");
s = Console.ReadLine();
b = Convert.ToInt32(s);
sum = a + b;
System.Console.WriteLine($"{a} + {b} = {sum}");
