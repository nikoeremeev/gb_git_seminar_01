// Задача №27: Определить количество цифр в числе.

Console.Write("Введите число = ");
int num = int.Parse(Console.ReadLine());

int count = 0;
if (num == 0)
{
    count = 1;
}
else
{
    while (num != 0)
    {
        count++;
        num /= 10;
        Console.WriteLine(num);
    }
}
Console.Write("количество цифр в числе = " + count);