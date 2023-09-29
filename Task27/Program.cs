// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;

int SumOfDigits(int num)
{
    int temp = 0;
    int result = 0;
    if (num < 0) 
    {
        temp = -num;
    }
    else temp = num;

    for (int i = 0; temp > 0; i++)
    {
        result += temp % 10;
        temp = temp / 10;
    }
    return result;
}

Write("Введите любое целое число: ");
int number = Convert.ToInt32(ReadLine());

int sumOfDigits = SumOfDigits(number);
WriteLine($"{number} -> {sumOfDigits}");