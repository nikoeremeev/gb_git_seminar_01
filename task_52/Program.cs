// Задача №59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Write("Введите размерность матрицы n*n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
Console.WriteLine();
Console.WriteLine("Исходная матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int minimum = (int)Math.Pow(2, 16);
int row = 0;
for (int i = 0; i < n; i++)
{
    int summ = 0;
    for (int j = 0; j < n; j++)
    {
        summ += array[i, j];
    }
    if (summ < minimum)
    {
        minimum = summ;
        row = i;
    }
}
Console.WriteLine();
Console.WriteLine("Номер строки с наименьшей суммой элементов (отсчет от нуля!): " + row);