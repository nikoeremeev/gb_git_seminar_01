Random rand = new Random();
            Console.Write("введите минимальное значение: ");  // введите минимальное значение
            int min = int.Parse(Console.ReadLine());
            Console.Write("введите максимальное значение: "); // введите максимальное значение
            int max = int.Parse(Console.ReadLine());
            Console.Write("введите количество строк массива: "); // введите количество строк массива
            int m = int.Parse(Console.ReadLine());
            Console.Write("введите количество столбцов массива: "); // введите количество столбцов массива
            int n = int.Parse(Console.ReadLine());
            double[,] arr = new double[m, n];
            Console.WriteLine("массив:"); // массив
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    arr[i, k] = Math.Round((rand.Next(min, max + 1)) * 1.1, 2);
                    Console.Write(arr[i, k] + "\t");
                }
                Console.WriteLine();
            }