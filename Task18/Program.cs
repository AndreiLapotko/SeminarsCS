// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string QuarterToRange(int x)
{
    if (x == 1) return "x > 0, y > 0";
    if (x == 2) return "x < 0, y > 0";
    if (x == 3) return "x < 0, y < 0";
    if (x == 4) return "x > 0, y > 0";
    return null;
} 

Console.WriteLine("Введите номер четверти");
Console.Write("Quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = QuarterToRange != null ? $"диапазон координат для указанной четверти: {QuarterToRange}" : "Некорректный ввод!";
Console.WriteLine(result);
// if (quarter > 0 && quarter < 5) 
// {
//     string result = QuarterToRange(quarter);
//     Console.WriteLine(result);
// }
// else Console.WriteLine("Некорректный ввод!");