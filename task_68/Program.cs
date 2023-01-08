// Задача №68: Показать натуральные числа от M до N, N и M заданы

void ShowNumbers(int M, int N)
{
    if (N < M) return;
    ShowNumbers(M, N - 1);
    Console.Write(N + " ");
}
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
ShowNumbers(M, N);