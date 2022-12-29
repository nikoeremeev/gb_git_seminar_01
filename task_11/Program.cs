// Задача №11: Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

Console.Write("Введите число из отрезка [10, 99]: ");

int num = int.Parse(Console.ReadLine());
if (num > 9 && num < 100)
{
    if (num / 10 > num % 10)
    {
        Console.WriteLine("Наибольшая цифра числа " + num + " равна " +
            num / 10 + ".");
    }
    else if (num / 10 < num % 10)
    {
        Console.WriteLine("Наибольшая цифра числа " + num + " равна " +
            num % 10 + ".");
    }
    else
    {
        Console.WriteLine("Цифры в числе " + num + " равны!");
    }
}
else
{
    Console.WriteLine("Введите число из отрезка [10, 99]!!!");
}