// Задача №19:  Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0.

Console.Write("Введите координату X (не равно 0): ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y (не равно 0): ");
int Y = int.Parse(Console.ReadLine());

if (X == 0 || Y == 0)
{
    Console.WriteLine("Точка находится НИ в одной из четвертей!");
}
else if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой четверти.");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во второй четверти.");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти.");
}
else 
{
    Console.WriteLine("Точка находится в четвертой четверти.");
}