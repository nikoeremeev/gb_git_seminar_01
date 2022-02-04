// Задача №10: Показать вторую цифру трёхзначного числа.
Console.Write("Введите трехзначное число: ");

int num = int.Parse(Console.ReadLine());

Console.WriteLine("Вторая цифра числа " + num + " равна " + num / 10 % 10 + ".");
 