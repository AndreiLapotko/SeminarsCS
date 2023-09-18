// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое любое целое число a: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе любое целое число b: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе любое целое число c: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;

Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} -> {max}");