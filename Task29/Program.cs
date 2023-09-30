// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using static System.Console;

int[] RandomArray(int arrLength, int arrMax)
{
    int[] arr = new int[arrLength];
    Random rand = new Random();
    // string output1 = string.Empty;
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = rand.Next(arrMax + 1);
        // output1 += (i == arrLength - 1) ? $"{arr[i]} " : $"{arr[i]}, ";
    }
    // Write(output1);
    return arr;
}

void PrintArray(int[] array)
{
    string output1 = string.Empty;
    string output2 = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output1 += (i == array.Length - 1) ? $"{array[i]} ->  " : $"{array[i]}, ";
        output2 += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}]";
    }
    Write(output1);
    WriteLine(output2);
}

Write("Input the Length of Array: ");
int arrLength = Convert.ToInt32(ReadLine());
Write("Input the MAX value of Array: ");
int maxValue = Convert.ToInt32(ReadLine());

int[] arr = RandomArray(arrLength, maxValue);
PrintArray(arr);