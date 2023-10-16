// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

// Реализуйте класс Answer, который содержит следующие статические методы:

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. 
//     Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. Метод принимает двумерный массив целых чисел matrix и 
//     возвращает массив из двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

// Аргументы, передаваемые в метод/функцию:

// '9, 1, 7; 1, 2, 3; 4, 5, 6'
// На выходе:


// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Сумма наименьшей строки (строка 2): 6

int[,] GenerateRandomMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine(string.Empty);
    }
}

int SumOfRow(int[,] matrix, int row)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[row, j];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int[] arr = new int[2];
    arr[1] = SumOfRow(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (SumOfRow(matrix, i) < arr[1])
        {
            arr[1] = SumOfRow(matrix, i);
            arr[0] = i;
        }
    }
    return arr;
}

int[,] testMatrix = GenerateRandomMatrix(8, 3, 1, 10);
PrintMatrix(testMatrix);

int[] result = MinimumSumRow(testMatrix);
Console.WriteLine();
Console.WriteLine($"Сумма наименьшей строки (строка {result[0]}): {result[1]}");