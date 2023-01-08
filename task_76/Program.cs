/*
Задача №76: Есть число N. Скольно групп M, 
можно получить при разбиении всех чисел на группы, 
так чтобы в одной группе все числа были взаимно просты.
*/


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int row = (int)(Math.Ceiling(Math.Log2(N)));
int[,] array = new int[row, N];
int[] array_col = new int[row + 1];
int[] array_group = new int[row];
for (int i = 0; i < row; i++)
{
    array_group[i] = (int)Math.Pow(2, i);
    Console.Write(array_group[i] + " ");
}
Console.WriteLine();
for (int i = 1; i <= N; i++)
{
    int col = 0;
    for (int j = 1; j < row; j++)
    {
        if (i == 1)
        {
            col = 0; break;
        }
        if (i % array_group[j] != 0)
        {
            col = j;
            break;
        }
        else if (i == array_group[j])
        {
            col = j;
            break;
        }
    }
    array[col, array_col[(col)]] = i;
    array_col[col] += 1;
}
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (array[i, j] > 0) Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
/*
Console.Clear();

Console.Write("Enter N: ");
int numb = Int32.Parse(Console.ReadLine());
int groop = 0;
for (int i = 1; i <= numb; i++)
{
    if (i == Math.Pow(2, groop))
    {
        Console.WriteLine();
        groop++;
        Console.Write($"{groop}-Group");
    }
    Console.Write($"{i,5}");
}
*/