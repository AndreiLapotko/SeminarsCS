// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.Write("Введите первое число a: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) Console.WriteLine($"a = {firstNumber}; b = {secondNumber} -> max = {firstNumber}");
else Console.WriteLine($"a = {firstNumber}; b = {secondNumber} -> max = {secondNumber}");