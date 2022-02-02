// Подсчитать сумму четных чисел от 1 до 15
Console.Clear();
int a = 0;
int s = 0;
while (a < 15)
{
    a = a + 1; //счетчик
    if (a % 2 == 0) s = s + a; //сумматор
    System.Console.WriteLine(a);
}
Console.WriteLine(s);
