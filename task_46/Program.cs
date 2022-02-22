// Задача №53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число для поиска: ");
int number = int.Parse(Console.ReadLine());
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
bool flag = true;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i,j] == number)
        {
            flag = false;
            Console.Write($"({i},{j})  ");
        }
    }
}
if (flag)  Console.WriteLine("Такого элемента нет.");