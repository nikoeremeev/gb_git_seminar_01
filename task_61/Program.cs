// Задача №61: Найти произведение двух матриц.


int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void ShowArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк первой матрицы: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int col1 = int.Parse(Console.ReadLine());
int[,] array1 = new int[row1, col1];
Console.WriteLine();
Console.WriteLine("Исходная матрица:");
array1 = CreateArray(row1, col1);

Console.WriteLine();

Console.Write("Введите количество строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int col2 = int.Parse(Console.ReadLine());
int[,] array2 = new int[row2, col2];
Console.WriteLine("Исходная матрица:");
array2 = CreateArray(row2, col2);

Console.WriteLine();
int[,] result = new int[row1, col1];
if (col1 != row2)
{
    Console.WriteLine("Количество столбцов первой матрицы не равно " +
    "количеству строк второй матрицы! Умножение невозможно!");
}
else
{
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            int sum = 0;
            for (int p = 0; p < col1; p++)
            {
                sum += array1[i, p] * array2[p, j];
            }
            result[i, j] = sum;
        }
    }
    ShowArray(result, row1, col2);
}