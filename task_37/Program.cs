// Задача №44: Найти точку пересечения двух прямых заданных уравнением:
// y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы.

double[] LineParam(string parametrs)
{
    string[] perem = parametrs.Split(' ');
    double[] param = new double[perem.Length];
    for (int i = 0; i < perem.Length; i++) param[i] = double.Parse(perem[i]);
    return param;
}

Console.Write("Введите через пробел парамеры первой прямой y = k1 * x + b1 (например: k1 b1): ");
string parametrs = Console.ReadLine();
double[] ex1 = LineParam(parametrs);
Console.Write("Введите через пробел парамеры второй прямой y = k2 * x + b2 (например:k2 b2): ");
parametrs = Console.ReadLine();
double[] ex2 = LineParam(parametrs);
double[] point = new double[2];
if (ex1[0] == ex2[0]) Console.WriteLine("Прямые паралелльны, т.к. к1 равно к2.");
else
{
    point[0] = (ex2[1] - ex1[1]) / (ex1[0] - ex2[0]); // (b2-b1)/(k1-k2)
    point[1] = (ex1[0] * ((ex2[1] - ex1[1]) / (ex1[0] - ex2[0])) + ex1[0]); // k1 * ((b2-b1)/(k1-k2)) + b1
    Console.WriteLine($"Точка пересечения ({point[0]}, { point[1]})");
}
