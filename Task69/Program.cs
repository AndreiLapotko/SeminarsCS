// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int UserNumber(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double PoweringAbyB(int a, int b) // 2,-2  2,-1  2,0
{
    // if (b > 0)
    // {
    //     if (b == 0) return 1; //3,0
    //     return a * PoweringAbyB(a, b - 1); //3,5 - 3,4 - 3,3 - 3,2 - 3,1
    //     //return 1 * 3 * 3 * 3 * 3 * 3 = 243
    // }
    // else
    // {
    //     double result = 1;
    //     if (b == 0) return 1;
    //     result = 1/(a * PoweringAbyB(a, b + 1)); // не работает!!!!
    //     return result; // 2,-2  2,-1  
    //     //    1 * 2 * 2 = 4  
    // }
    if (b == 0) return 1;
    if (b < 0) return (1 / PoweringAbyB(a, -b));
    return a * PoweringAbyB(a, b - 1);
}


int a = UserNumber("Enter digit a: ");
int b = UserNumber("Enter power b: ");
double powerAB = 0;
// if (b >= 0)
// powerAB = PoweringAbyB(a, b);
// else 
// powerAB = 1/PoweringAbyB(a, -b);
powerAB = PoweringAbyB(a, b);
Console.WriteLine($"A in power B: {powerAB}");