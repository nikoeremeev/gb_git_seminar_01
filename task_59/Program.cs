// Задача №66: Показать натуральные числа от 1 до N, N задано.

void ShowNumbers(int number)
{
    if (number < 1) return;
    ShowNumbers(number - 1);
    Console.Write(number + " ");
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
ShowNumbers(N);