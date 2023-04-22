// Возведение числа в степень
int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int A = EnterNumber("Введите число: ");
int B = EnterNumber("Введите степень числа: ");

int x = 1;
int y = 1;
while (x <= B)
{
    y=y*A;
    x++;
}

Console.WriteLine($"Число в степени равно: {y}");