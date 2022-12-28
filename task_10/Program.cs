// Задача №10: Показать вторую цифру трёхзначного числа.


Console.Write("Введите трехзначное число: ");

int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 1000)
{
    Console.WriteLine("Вторая цифра числа " + num + " равна " + num / 10 % 10 + ".");
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}