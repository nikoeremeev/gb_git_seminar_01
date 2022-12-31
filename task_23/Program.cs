// Задача №23: Показать таблицу квадратов чисел от 1 до N.

Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine());
Console.Write("Числа" + "\t\t");
for (int i = 1; i <= N; i++)
{
    Console.Write(i + "\t");
}
Console.WriteLine();
Console.Write("Квадраты" + "\t");
for (int i = 1; i <= N; i++)
{
    Console.Write(i * i + "\t");
}