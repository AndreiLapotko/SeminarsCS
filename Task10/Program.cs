// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetIntUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetSecondDigit(int number)
{
    int result = (number / 10) % 10;
    return result;
}

bool CheckingRange(int num)
{
    return num >= 100 && num < 1000;
}

int threeDigits = GetIntUserInput("Введите любое целое трёхзначное число");
if (threeDigits < 0) threeDigits *= -1;
if (CheckingRange(threeDigits))
{
    int secondDigit = GetSecondDigit(threeDigits);
    Console.WriteLine($"Вторая цифра Вашего числа: {secondDigit}");
}
else Console.WriteLine("Некорректнй ввод, данные не соответствуют требованиям!");