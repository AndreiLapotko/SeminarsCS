// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetUserInputInt(string msg)
{
    int num = 0;
    bool check = CheckInput(num);
    while (!check)
    {
        Console.Write($"{msg}: ");
        string? value = Console.ReadLine();
        num = Convert.ToInt32(value);
        check = CheckInput(num);
        if (!check) Console.WriteLine("Введите корректные данные!");
    }
    return num;
}

bool CheckInput(int n)
{
    return (n < 1 ? false : true);
}

int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akker(m - 1, 1);
    return Akker(m - 1, Akker(m, n - 1));
}

int m = GetUserInputInt("Введите первое натуральное число");
int n = GetUserInputInt("Введите второе натуральное число");
Console.WriteLine(m > 3 || n > 5 ? "Слишком большие данные! Попробуйте уменьшить m или n." : $"m = {m}; n = {n} -> A(m,n) = {Akker(m, n)}");