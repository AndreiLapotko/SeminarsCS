// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

int GetIntUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void TableOfSquare(int x)
{
    int count = 0;
    while (count <= x)
    {
        Console.WriteLine($"{count, 3} -> {count * count, 5}");
        count++;
    }
}

int num = GetIntUserInput("Введите любое число");
TableOfSquare(num);