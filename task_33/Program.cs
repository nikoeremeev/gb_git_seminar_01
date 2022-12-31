// Задача №33: Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива.

Console.Clear();
int[] array = new int[12];
int summ_p = 0;
int summ_m = 0;
Console.WriteLine();
Console.Write("Полученный массив: [ ");
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
Console.WriteLine();
for (int i = 0; i < 12; i++)
{
    if (array[i] > 0)
    {
        summ_p += array[i];
    }
    else
    {
        summ_m += array[i];
    }
}
Console.WriteLine("Сумма положительных элементов массива = " + summ_p);
Console.WriteLine("Сумма отрицательных элементов массива = " + summ_m);