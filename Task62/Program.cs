// Задача 62: Заполните спирально массив 4 на 4.

int[,] arr = new int[4, 4]; // Создаем двумерный массив размером 4 на 4
int n = 4; // Размер массива
int value = 1; // Значение для заполнения элементов массива
int startX = 0; // Индекс начальной строки
int startY = 0; // Индекс начального столбца
int endX = n - 1; // Индекс конечной строки
int endY = n - 1; // Индекс конечного столбца

// Заполняем массив значениями в спиральном порядке
while (startX <= endX && startY <= endY)
{

    // Заполнение верхней строки
    for (int i = startY; i <= endY; i++)
    {
        arr[startX, i] = value++;
    }
    startX++;

    // Заполнение правого столбца
    for (int i = startX; i <= endX; i++)
    {
        arr[i, endY] = value++;
    }
    endY--;

    // Заполнение нижней строки
    for (int i = endY; i >= startY; i--)
    {
        arr[endX, i] = value++;
    }
    endX--;

    // Заполнение левого столбца
    for (int i = endX; i >= startX; i--)
    {
        arr[i, startY] = value++;
    }
    startY++;
}

// Вывод массива на экран
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}
Console.ReadLine();