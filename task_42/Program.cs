// Задача №42: Определить, сколько чисел больше 0 введено с клавиатуры.

Console.Write("Введите через пробел числа: ");
string numbers = Console.ReadLine();
string[] numbers_array = numbers.Split(' ');
int count = 0;
for (int i = 0; i < numbers_array.Length; i++)
{
    if (int.Parse(numbers_array[i]) > 0) count++;
}
Console.WriteLine($"Количество чисел больше 0 введенных с" +
    " клавиатуры равно {count}.");