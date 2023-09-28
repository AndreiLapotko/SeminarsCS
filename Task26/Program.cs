// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int LengthOfNumber(int num)
{
    if (num == 0) return 1;
    int count = 0;
    while (num!=0)
    {
        count++;
        num = num/10;
    }
    return count;
}

int number = GetUserInput("Enter a number");
int length = LengthOfNumber(number);

Console.WriteLine($"{number} -> {length}");