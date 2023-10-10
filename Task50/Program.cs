// Задача 50: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число.
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и
//      возвращает матрицу, удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице.
//      Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением.
//      Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, 
//      а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.
// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 
//      Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition.
//       Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".
// Примеры:
// n = 3;
// m = 4;
// k = 2;
// x = 8;
// y = 3;
// /*
// 1   3   5   7   
// 9   11  13  15  
// 17  19  21  23  
// There is no such index
// */

// n = 4;
// m = 5;
// k = 3;
// x = 2;
// y = 2;

// /*
// 1   4   7   10  13  
// 16  19  22  25  28  
// 31  34  37  40  43  
// 46  49  52  55  58  
// The number in [2, 2] is 19
// */

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int sum = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = sum;
            sum += k;
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
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

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    if (rowPosition > 0 && rowPosition < matrix.GetLength(0) && columnPosition > 0 && columnPosition < matrix.GetLength(1))
    {
        int[] array2 = new int[2];
        array2[0] = matrix[rowPosition - 1, columnPosition - 1];
        return array2;
    }
    int[] array1 = { 0 };
    return array1;
}

void PrintCheckIfError (int[] results, int X, int Y)
{
    Console.WriteLine(results[0] == 0 ? "There is no such index" : $"The number in [{X}, {Y}] is {results[0]}");
}

void PrintResultArr(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i],5}");
    }
    Console.WriteLine(string.Empty);
}


int n = 3;
int m = 4;
int k = 2;
int x = 2;
int y = 3;


int[,] testMatrix = CreateIncreasingMatrix(m, n, k);
PrintArray(testMatrix);

int[] resultArr = FindNumberByPosition(testMatrix, x, y);
PrintResultArr(resultArr);
PrintCheckIfError(resultArr, x, y);