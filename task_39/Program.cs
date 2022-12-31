// Задача №39: Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введите размер массива");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
Console.WriteLine();
Console.Write("Полученный массив: [ ");
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine();

int[] array2 = new int[(N + 1) / 2];
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array[i] * array[N - i - 1];
}
Console.Write("Полученный массив: [ ");
for (int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i] + " ");
}
Console.WriteLine(" ]");