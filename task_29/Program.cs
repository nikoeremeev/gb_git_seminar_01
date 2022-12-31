// Задача №29: Написать программу вычисления произведения чисел от 1 до N.


Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine());
int product = 1;
for (int i = 1; i <= N; i++)
{
    product *= i;
}
Console.Write("произведение чисел от 1 до " + N + " = " + product);