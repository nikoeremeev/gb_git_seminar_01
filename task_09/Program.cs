// Задача №9: Показать последнюю цифру трёхзначного числа.


Console.Write("Введите трехзначное число: ");

int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 1000)
{
    Console.WriteLine("Последняя цифра числа " + num + " равна " +
        num % 10 + ".");
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}