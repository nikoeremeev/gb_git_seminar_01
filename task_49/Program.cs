// Задача №49: Показать двумерный массив размером m×n, 
// заполненный вещественными числами.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(new Random().Next(0, 10) * 1.01, 2);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}