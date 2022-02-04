// Задача №16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

Console.Write("Введите число обозначающее день недели (от 1 до 7): ");

int num = int.Parse(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной.");
}
else
{
    Console.WriteLine("Рабочий день!");
}
