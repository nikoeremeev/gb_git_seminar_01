// Задача №21: Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int temporary = number;
int reverse_number = 0;

while(number != 0)
{
    int last_digit = number % 10;
    reverse_number = reverse_number * 10 + last_digit;
    number = number / 10;
}

if (reverse_number == temporary)
{
    Console.WriteLine("Число " + temporary + " является палиндромом.");
}
else
{
    Console.WriteLine("Число " + temporary + " НЕ является палиндромом.");
}
