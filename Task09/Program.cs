// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int number = new Random().Next(10, 100);

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// Console.WriteLine(number);
// if (firstDigit > secondDigit) Console.WriteLine(firstDigit);
// else Console.WriteLine(secondDigit);

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine(maxDigit);

Console.WriteLine(number);
Console.WriteLine(MaxDigit(number));