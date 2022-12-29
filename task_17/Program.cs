// Задача №17: По двум заданным числам проверять является ли одно квадратом другого.

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

if (numA * numA == numB || numB * numB == numA)
{
    Console.WriteLine("Является.");
}
else
{
    Console.WriteLine("Не является.");
}