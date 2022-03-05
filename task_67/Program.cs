// Задача №74: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

void PrintAbc(char[] abc, char[] word, int N = 0)
{
    if (N == word.Length)
    {
        Console.WriteLine($"{new String(word)}"); return;
    }
    for (int i = 0; i < abc.Length; i++)
    {
        word[N] = abc[i];
        PrintAbc(abc, word, N+1);
    }
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
char[] abc = {'а', 'и', 'с', 'в'};
PrintAbc(abc, new char[N]);