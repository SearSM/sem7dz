// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string FindNumber(int[,] massive, int number)
{
    string result = String.Empty;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i, j] == number)
            {
                return result = ($"Число {number} есть в данном массиве и находится {i}, {j}");
            }
        }
    }
    return result = ($"{number} -> такого числа в массиве нет");
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
int num = GetInfo("Введите число, которое необходимо найти: ");
PrintDoubleMassive(massive);
Console.WriteLine($"{FindNumber(massive, num)}");