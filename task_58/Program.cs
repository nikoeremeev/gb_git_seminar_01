/*
Задача №58: Написать программу, которая в двумерном массиве заменяет строки
на столбцы или сообщить, что это невозможно 
(в случае, если матрица не квадратная).
*/


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

if (m == n)
{
    int temp;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            temp = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = temp;
        }
        Console.WriteLine();
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[j, i] + "\t");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("Матрица НЕ квадратная");

