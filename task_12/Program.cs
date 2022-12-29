// Задача №12: Удалить вторую цифру трёхзначного числа.


Console.Write("Введите трехзначное число: ");

int num = int.Parse(Console.ReadLine());

int number = (num / 100 * 10) + (num % 10);

Console.WriteLine("Число " + num + " после удаления второй цифры " +
    number + ".");