// Задача №36: Задать массив, 
// заполнить случайными положительными трёхзначными числами. 
// Показать количество нечётных/чётных чисел.

Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
Console.WriteLine();
Console.Write("Полученный массив: [ ");
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine();

int count_even = 0;
int count_odd = 0;

for (int i = 0; i < N; i++)
{
    if (array[i] % 2 == 0) count_even++;
    else count_odd++;
}
Console.WriteLine($"В массиве количество нечетных чисел равно {count_odd}");
Console.WriteLine($"В массиве количество четных чисел равно {count_even}");