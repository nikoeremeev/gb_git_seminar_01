/*Задача 5: Написать программу вычисления значения функции y = f(x).
y = 2x — 10, если x > 0
y = 0, если x = 0
y = 2 * |x| — 1, если x < 0

Требуется найти значение функции по переданному x.
*/


Console.Write("Введите число x: ");
int x = int.Parse(Console.ReadLine());
int y;
if (x > 0) y = 2 * x - 10;
else if (x < 0) y = 2 * Math.Abs(x) - 1;
else y = 0;

Console.WriteLine("y =  " + y + ".");