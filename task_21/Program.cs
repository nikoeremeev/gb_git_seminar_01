// Задача №28: Подсчитать сумму цифр в числе.

Console.Write("Введите число = ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

while (num != 0)
{
    sum += num % 10;
    num /= 10;
}
if (sum < 0) Console.Write("Сумма цифр в числе = " + sum * (-1));
else Console.Write("Сумма цифр в числе = " + sum);