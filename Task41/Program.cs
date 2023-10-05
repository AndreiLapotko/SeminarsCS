// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;

int GetUserInput(string msg)
{
    Write(msg);
    int num = Convert.ToInt32(ReadLine());
    return num;
}

int[] FillArray()
{
    int size = GetUserInput("Введите количество чисел для обработки: ");
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetUserInput("Введите любое целое число: ");
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write(i == arr.Length - 1 ? $"{arr[i]}" : $"{arr[i]}, ");
    }
}

int CountingPositives(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = FillArray();
int countPositives = CountingPositives(array);

PrintArray(array);
Write($" -> {countPositives}");