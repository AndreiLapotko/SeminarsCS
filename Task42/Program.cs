// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int quarter = Convert.ToInt32(Console.ReadLine());
    return quarter;
}

string DecimalToAnyNotation(int number, int baseNum)
{
    string result = String.Empty;

    while (number > 0)
    {
        result = number % baseNum + result;
        number /= baseNum;
    }
    return result;
}

int DecimalToAnyNotationInt(int number, int baseNum)
{
    int result = 0;
    int mult = 1;

    while (number > 0)
    {
        result = (number % baseNum) * mult + result;
        mult *= 10;
        number /= baseNum;
    }
    return result;
}

int num = GetUserInput("Enter a number");
int baseNumber = GetUserInput("Enter base number < 10");
int binNum = DecimalToAnyNotationInt(num, baseNumber);
string binNum2 = DecimalToAnyNotation(num, baseNumber);
Console.WriteLine($"{num} -> {binNum} или {binNum2}");