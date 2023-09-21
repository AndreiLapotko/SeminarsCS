// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool DivTo7And23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

int number = GetUserInput("Ведите число");

bool result = DivTo7And23(number);
Console.WriteLine(result ? "Да" : "Нет");