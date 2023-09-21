// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Int64 GetIntUserInput(string str)
{
    Console.Write($"{str}: ");
    Int64 num = Convert.ToInt64(Console.ReadLine());
    return num;
}

int NormalizeNumber(Int64 num)
{
    if (num < 0) num *= -1;
    while (num > 1000)
    {
        num /= 10;
    }
    return Convert.ToInt32(num);
}

int LastDigitAnyNumb(int num)
{
    int last = num % 10;
    return last;
}

Int64 userNumber = GetIntUserInput("Введите любое целое число");
int normNumber = NormalizeNumber(userNumber);
if (normNumber < 100) Console.WriteLine($"{userNumber} -> третьей цифры нет");
else
{
    int lastDigit = LastDigitAnyNumb(normNumber);
    Console.WriteLine($"{userNumber} -> {lastDigit}");
}