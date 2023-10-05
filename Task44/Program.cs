// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetUserInput(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    //Console.Write($"{arr[^1]}");// ^1 последний элемент массива
}

int[] Fibonacci(int n)
{
    int size = n;
    if (n == 0) size = n + 1;
    if (n == 1) size = n + 1;

    int[] arr = new int[size];
        if (size == 1) return arr;
        if (size == 2)
        {
            arr[1] = 1;
            return arr;
        }
        arr[1] = 1;
        for (int i = 2; i < n; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
    return arr;
}

int num = GetUserInput("Введите N: ");
int[] array = Fibonacci(num);
Console.Write($"Если N = {num} -> ");
PrintOut(array);