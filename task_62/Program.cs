// Задача №69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.

Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
int summa = 0;
int SumNumber(int m, int n)
{
    if(m < n)
    {
       summa = summa + m;
         SumNumber(m + 1, n);
       return summa + n;
    }
    else if(m > n)
    {
        summa = summa +n;
        SumNumber(m,n+1);
       return summa + m;
    }
    else
    {
       return summa;    
    }
}
Console.WriteLine($"Сумма элементов в промежутке от {m} до {n} равна {SumNumber(m,n)}");