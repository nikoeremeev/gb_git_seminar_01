// Задача №67: Показать натуральные числа от N до 1, N задано.

void ShowNumbers(int number)
{
    if (number < 1) return;
    Console.Write(number + " ");
    ShowNumbers(number - 1);
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
ShowNumbers(N);