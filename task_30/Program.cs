// Задача №37: В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

Console.Clear();
int[] array = new int[123];
Console.WriteLine();
Console.Write("Полученный массив: [ ");
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(0, 200);
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine();
int count = 0;
for (int i = 0; i < 123; i++)
{
    if ((10 <= array[i]) && (array[i] <= 99))
    {
        count++;
    }
}
Console.WriteLine("Элементы из отрезка [10,99] встречаются " + count + " раз");