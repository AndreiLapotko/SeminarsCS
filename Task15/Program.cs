// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int GetIntUserInput(string str)
{
    int num = 0;
    bool check = IsCorrectRange(num);
    while (!check) //запрос до тех пор пока пользователь не введёт корректные данные
    {
        Console.Write($"{str}: ");
        string? value = Console.ReadLine();
        num = Convert.ToInt32(value);
        check = IsCorrectRange(num);
        //if (check) break;
        //else Console.WriteLine($"Дня недели с номером {num} не существует!");
        if (!check) Console.WriteLine($"Дня недели с номером {num} не существует!");
    }
    return num;
}

bool IsCorrectRange(int num)
{
    return (num > 0 && num < 8) ? true : false;
}

bool IsItWeekend(int num)
{
    return num == 6 || num == 7 ? true : false;
}

int day = GetIntUserInput("Введите номер дня недели");

if (IsItWeekend(day)) Console.WriteLine($"{day} -> Да");
else Console.WriteLine($"{day} -> Нет");