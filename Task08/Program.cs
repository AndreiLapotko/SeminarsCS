// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите любое целое число больше 1: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
   int even = 2;

   Console.Write($"{number} -> ");
   while (even <= number)
   {
      Console.Write($"{even}, ");
      even += 2;
   }
}
else Console.Write("Введите корректные данные!");