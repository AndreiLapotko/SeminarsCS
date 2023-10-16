// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB. 
//     Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply." 
//     В противном случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц matrixA и matrixB. Метод возвращает новую матрицу, 
//     которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// Аргументы, передаваемые в метод/функцию:

// '1,2;3,4'
// На выходе:


// Исходная матрица:
// 1   2   
// 3   4   

// Matrix B:
// 5   6   
// 7   8   

// Multiplication result:
// 19  22  
// 43  50

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

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        PrintMatrix(MatrixMultiplication(matrixA, matrixB));
    }
    else Console.WriteLine("It is impossible to multiply.");
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            resultMatrix[i, j] = matrixA[i, 0] * matrixB[0, j];
            for (int k = 1; k < matrixA.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
}

int[,] testA = new int[,]
{
{1, 2, 3},
{4, 5, 6},
};

int[,] testB = new int[,]
{
{5, 6},
{7, 8},
};

// int[,] testA = GenerateRandomMatrix(3, 2, 1, 10);
// int[,] testB = GenerateRandomMatrix(2, 5, 1, 10);
PrintMatrix(testA);
Console.WriteLine(string.Empty);
PrintMatrix(testB);
Console.WriteLine(string.Empty);
MultiplyIfPossible(testA, testB);
