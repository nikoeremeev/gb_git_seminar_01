// Задача №56: Написать программу, которая обменивает элементы первой строки и последней строки.

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
int[] temp = new int[n];
for (int i = 0; i < n; i++)
{
    temp[i] = array[m-1, i];
    array[m-1, i] = array[0, i];
    array[0, i] = temp[i];
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}