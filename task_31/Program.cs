// Задача 31: Задать массив из 8 элементов и вывести их на экран.


Console.Clear();
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
Console.Write("Полученный массив: [ ");
for (int i = 0; i < 8; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
