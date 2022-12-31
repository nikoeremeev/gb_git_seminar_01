// Задача №25: Найти сумму чисел от 1 до А.

Console.Write("Введите число A = ");
int A = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= A; i++)
{
    sum += i;
}
Console.Write("сумму чисел от 1 до А = " + sum);