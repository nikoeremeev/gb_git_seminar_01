// Задача №75: Есть два массива info и data. Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей. 
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data. 
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.

int [] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int [] info = {2, 3, 3, 1 };
int [] result = new int[info.Length];
int count = 0;
for (int i = 0; i < result.Length; i++)
{
    int temp = 0;
    for (int j = 0; j < info[i]; j++)
    {
        temp += data[count + j] * (int)Math.Pow(2, j);
        Console.Write($"{data[count + j]}");
    }
    result[i] = temp;
    Console.Write("\t");
}
Console.WriteLine();
for (int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]}\t");
}