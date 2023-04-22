// Сумма цифр в числе
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int x = 0;
int y = 0;
while (N > 0)
{
    x = N%10;
    N = N/10;
    y = y+x;
}

Console.WriteLine($"Сумма цифр в числе равна: {y}");