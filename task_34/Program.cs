// Задача №34: Написать программу замену элементов массива на противоположные.

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

for (int i = 0; i < (N + 1) / 2; i++)
{
    int temp = array[N - i - 1];
    array[N - i - 1] = array[i];
    array[i] = temp;
}
Console.Write("Полученный массив: [ ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ]");