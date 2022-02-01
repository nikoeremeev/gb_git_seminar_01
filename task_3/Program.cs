// Задача 6: Выяснить является ли число чётным.

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

if (numberA % 2 == 0) 
{
    Console.WriteLine("Число " + numberA + " четное.");
}
else
{
    Console.WriteLine("Число " + numberA + " нечетное.");
}