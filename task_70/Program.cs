// Задача №70: Найти сумму цифр числа.


int SumNumbers(int N)
{
    if (N == 0) return 0;
    int last_digit = N % 10;
    return last_digit + SumNumbers(N / 10);
}
Console.Write("Введите число N: ");
int K = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Сумма цифр числа {K} равна {SumNumbers(K)}");