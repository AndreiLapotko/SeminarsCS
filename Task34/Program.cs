// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

int GetUserInput(string text)
{

    Write($"{text}: ");
    int num = Convert.ToInt32(ReadLine());
    return num;
}

int[] CreateArrarRndint(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[^1]}");
}

int length = GetUserInput("Input the amount of numbers");
int[] array = CreateArrarRndint(length, 100, 999);
int countEvenNumbers = CountEvenNumbers(array);

Write("[");
PrintOut(array);
Write("] -> ");
WriteLine(countEvenNumbers == 0 ? "No even numbers" : countEvenNumbers);