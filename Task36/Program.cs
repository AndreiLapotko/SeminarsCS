// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;

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

int SumOfNonEvens(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[^1]}");
}

Write("Input the Length of Array: ");
int arrLength = Convert.ToInt32(ReadLine());
Write("Input the min range's value of Array: ");
int minValueOfRange = Convert.ToInt32(ReadLine());
Write("Input the max range's value of Array: ");
int maxValueOfRange = Convert.ToInt32(ReadLine());

int[] array = CreateArrarRndint(arrLength, minValueOfRange, maxValueOfRange);
int sumOfNonEvens = SumOfNonEvens(array);

Write("[");
PrintOut(array);
Write("] -> ");
WriteLine(sumOfNonEvens);