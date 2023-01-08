/*
Задача №60 Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
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
for (int k = 0; k < 10; k++)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] == k) count++;
        }
    }
    if (count != 0) Console.WriteLine($"{k} встречается {count} раза");
}

