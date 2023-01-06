// Задача №55: Дан целочисленный массив. 
// Найти среднее арифметическое каждого из столбцов.

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
for (int j = 0; j < n; j++)
{
    double average = 0;
    for (int i = 0; i < m; i++)
    {
        average = average + array[i, j];
    }
    Console.Write($"{average / m}" + "\t");
}