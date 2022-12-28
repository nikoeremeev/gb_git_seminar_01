// Задача 1: 
// По двум заданным числам проверять является ли первое квадратом второго.


Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine("Число " + numberA + " является квадратом числа " +
    numberB + ".");
}
else
{
    Console.WriteLine("Число " + numberA + " не является квадратом числа " +
    numberB + ".");
}