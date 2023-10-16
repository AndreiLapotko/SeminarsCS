// Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

int[,,] GenerateMatrix(int rows, int cols, int deep, int n)
{
    int[,,] matrix = new int[rows, cols, deep];
    if (rows * cols * deep > 89 / n) return matrix;
    int value = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = value;
                value += n;
            }
        }
    }
    return matrix;
}

void Print3dMatrix(int[,,] matrix)
{
    if (matrix[0,0,0] == 0)
    {
        Console.WriteLine("С введёнными данными выполнение задания невозможно! Измените аргументы.");
        return;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"matrix[{i},{j},{k}] -> {matrix[i, j, k]}");
            }
            Console.WriteLine(string.Empty);    
        }
        Console.WriteLine(string.Empty);
    }
}

int[,,] testMatrix = GenerateMatrix(3, 3, 3, 3);
Print3dMatrix(testMatrix);