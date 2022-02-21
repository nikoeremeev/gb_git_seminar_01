// Задача №54: В матрице чисел найти сумму элементов главной диагонали.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
int summ = 0;
int size = n;
if (m < n) size = m;
for (int i = 0; i < size; i++)
{
    summ += array[i, i];
}
Console.Write($"Сумма элементов главной диагонали равна {summ}");