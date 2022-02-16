// Задача №38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
Console.WriteLine();
Console.Write("Полученный массив: [ ");
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine();

int summ = 0;

for (int i = 1; i < N; i += 2)
{
    summ += array[i];
}
Console.WriteLine($"Сумма чисел одномерного массива, стоящих на нечётной позиции равнаЖ: {summ}");