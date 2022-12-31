// Задача №24: Найти кубы чисел от 1 до N.

Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine());
Console.Write("Числа" + "\t");
for (int i = 1; i <= N; i++)
{
    Console.Write(i + "\t");
}
Console.WriteLine();
Console.Write("Кубы" + "\t");
for (int i = 1; i <= N; i++)
{
    Console.Write(i * i * i + "\t");
}