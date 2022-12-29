// Задача №20: Задать номер четверти, 
// показать диапазоны для возможных координат.

Console.Write("Введите номер четверти (от 1 до 4 включительно): ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Диапазон возможных координат для " + number +
        " четверти: X > 0, Y > 0.");
}
else if (number == 2)
{
    Console.WriteLine("Диапазон возможных координат для " + number +
        " четверти: X < 0, Y > 0.");
}
else if (number == 3)
{
    Console.WriteLine("Диапазон возможных координат для " + number +
        " четверти: X < 0, Y < 0.");
}
else if (number == 4)
{
    Console.WriteLine("Диапазон возможных координат для " + number +
        " четверти: X > 0, Y < 0.");
}
else
{
    Console.WriteLine("Введите корректный номер четверти от 1 до 4" +
        " включительно!");
}