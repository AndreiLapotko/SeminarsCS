// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите первое любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0) Console.WriteLine($"{number} -> да");
// else Console.WriteLine($"{number} -> нет");

if (number % 2 == 0) Console.WriteLine($"Число {number} является чётным");
else Console.WriteLine($"Число {number} не является чётным");