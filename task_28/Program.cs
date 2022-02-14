// Задача №35: Определить, присутствует ли в заданном массиве, некоторое число.

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int [] array = new int [12];
Console.WriteLine();
Console.Write("Полученный массив: [ ");
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine();
bool flag = false;
for (int i = 0; i < 10; i++)
{
    if (array[i] == N)
    {
        flag = true;
    }
    
}
if (flag)
{
    Console.WriteLine("Встречается.");
}
else
{
    Console.WriteLine("НЕ встречается.");
}