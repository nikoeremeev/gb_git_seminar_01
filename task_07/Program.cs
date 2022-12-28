// Задача 7: Показать числа от -N до N.

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

for (int i = -numberN; i <= numberN; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();