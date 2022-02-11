// Задача №30: Показать кубы чисел, заканчивающихся на четную цифру.

Console.Clear();
Console.Write("Введите число чисел, у которых кубы чисел, заканчивающихся на четную цифру = ");
int N = int.Parse(Console.ReadLine());
int count = 0;
int i = 1;

Console.WriteLine();
Console.Write("Кубы чисел, заканчивающихся на четную цифру: ");
while (count < N)
{   
    if ((i*i*i) % 2 == 0)
    {
        count++;
        Console.Write(i*i*i + " ");
        i++;
    }
    else i++;
}