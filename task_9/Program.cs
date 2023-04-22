// Задача №15: Дано число. Проверить кратно ли оно 7 и 23.

Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Число " + num + " кратно 7 и 23.");
}
else
{
    Console.WriteLine("Число " + num + " НЕ кратно 7 и 23.");
}
