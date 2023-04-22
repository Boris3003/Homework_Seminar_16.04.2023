// Вывод заданного массива на экран
Random random = new Random();
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = random.Next(0, 100);
}

for (int i = 0; i < 8; i++)
    Console.Write($"{array[i]} ; ");