// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


using static System.Console; // использовал для сокращения записи операторов консольного ввода/вывода
using System.Globalization; // необходимо для замены разделителя целой и дробной частей

double[] CreateArrRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        // arr[i] = rnd.NextDouble() * (max - min) + min; //в цикле необходимо округление, т.к. без него возможна визуальная арифметическая ошибка при определении разности
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2, MidpointRounding.AwayFromZero);
    }

    return arr;
}

void PrintOut(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        //Write($"{arr[i]:f2}, ");
        Write($"{arr[i]}, ");
    }
    //Write($"{arr[^1]:f2}");
    Write($"{arr[^1]}");
}

double GetMinOfArr(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double GetMaxOfArr(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

CultureInfo.CurrentCulture = new CultureInfo("en-US"); // Переопределяем системные значения. Необходимо для замены разделителя целой и дробной частей.

Write("Input the Length of Array: ");
int arrLength = Convert.ToInt32(ReadLine());
Write("Input the min range's value of Array: ");
int minValueOfRange = Convert.ToInt32(ReadLine());
Write("Input the max range's value of Array: ");
int maxValueOfRange = Convert.ToInt32(ReadLine());

double[] array = CreateArrRndDouble(arrLength, minValueOfRange, maxValueOfRange);
double min = GetMinOfArr(array);
double max = GetMaxOfArr(array);

Write("[");
PrintOut(array);
//Write($"] => {max:f2} - {min:f2} = {max - min:f2}");
Write($"] => {max} - {min} = {max - min}");