// Задача №40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
Console.WriteLine();
Console.Write("Полученный массив: [ ");
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine();

int min_number = array[0];
int max_number = array[0];

for (int i = 1; i < N; i++)
{
    if (array[i] > max_number) max_number = array[i];
    else if (array[i] < min_number) min_number = array[i];
}
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max_number - min_number}");