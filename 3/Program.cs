// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

string GetMean(int[,] massive)
{
    string finalResult = String.Empty;
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            result += massive[i, j];
        }
        finalResult += ($"{result / massive.GetLength(0):F1}; ");
    }
    return finalResult;
}

void PrintDoubleMassive (int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] MakeDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] massive = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            massive[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return massive;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите количество строк: ");
int columns = GetInfo("Введите количество столбцов: ");
int minValue = GetInfo("Введите начальный диапазон случайных чисел: ");
int maxValue = GetInfo("Введите максимальный диапазон случайных чисел: ");
int[,] massive = MakeDoubleMassive(rows, columns, minValue, maxValue);
PrintDoubleMassive(massive);
Console.WriteLine($"Среднее арифметическое каждого столбца: {GetMean(massive)}");