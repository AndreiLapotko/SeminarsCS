// Задача 21: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GetIntUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

int x1 = GetIntUserInput("Введите координату X первой точки: ");
int y1 = GetIntUserInput("Введите координату Y первой точки: ");
int z1 = GetIntUserInput("Введите координату Z первой точки: ");

Console.WriteLine("______________________");
int x2 = GetIntUserInput("Введите координату X второй точки: ");
int y2 = GetIntUserInput("Введите координату Y второй точки: ");
int z2 = GetIntUserInput("Введите координату Z второй точки: ");

double dist = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));