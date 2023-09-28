// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int A, int B)
{
    int res = A;

    for (int i = 1; i < B; i++)

    {
        checked
        {
        res *= A;
        }
    }
return res;
}

Console.Write("Введите любое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое положительное целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int powNumbers = Power(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {powNumbers}");