// Задача 8: Показать чётные числа от 1 до N.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int n = 1;
while (n <= num)
{
    if (n % 2 == 0) 
    {
        Console.WriteLine(n);
    }
    n += 1;
}