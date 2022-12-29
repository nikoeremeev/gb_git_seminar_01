// Задача №14: Найти третью цифру числа или сообщить, что её нет.


Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine());
int Count = 0;
int numbercount = num;
while (numbercount != 0)
{
    numbercount /= 10;
    Count++;
}
if (Count >= 3)
{
    int number = (num / ((int)Math.Pow(10, (-1 * (3 - Count))))) % 10;
    Console.WriteLine("У числа " + num + " третья цифра равна " + number + ".");
}
else
{
    Console.WriteLine("У числа " + num + " НЕТ третьей цифры.");
}
