// Задача 2: Даны два числа. Показать большее и меньшее число
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Число " + numberA + " большее.");
    Console.WriteLine("Число " + numberB + " меньшее.");
}
else if (numberA < numberB)
{
    Console.WriteLine("Число " + numberB + " большее.");
    Console.WriteLine("Число " + numberA + " меньшее.");
}
else
{
    Console.WriteLine("Числа равны.");
}