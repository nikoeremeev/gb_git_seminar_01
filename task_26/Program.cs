// Задача №26: Возведите число А в натуральную степень B используя цикл.

Console.Write("Введите число A = ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B = ");
int B = int.Parse(Console.ReadLine());
int product = 1;
for (int i = 1; i <= B; i++)
{
    product *= A;
}
Console.Write("число А в натуральной степени B = " + product);