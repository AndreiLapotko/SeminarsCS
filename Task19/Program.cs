// Задача 19: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно 
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// int GetIntUserInput(string text)
// {
//     int value = 0;
//     bool check = false;
//     while (!check) //запрос до тех пор пока пользователь не введёт корректные данные
//     {
//         Console.Write($"{text}: ");
//         value = Convert.ToInt32(Console.ReadLine());
//         if (IsValueInRange(value)) 
//         {
//             check = IsValueInRange(value);
//         }
//         else Console.WriteLine($"Число {value} вне пределов диапазона, введите корректные данные!");
//     }
//     return value;
// }

// bool IsValueInRange(int num)
// {
//     int number;
//     if (num < 0) number = num * -1;
//     else number = num;
//     return number >= 10_000 && number < 100_000;
// }

// bool IsItPalindrome(int x)
// {
//     int firstDigit = x / 10_000;
//     int secondDigit = x / 1000 % 10;
//     int fourthDigit = x / 10 % 10;
//     int fifthDigit = x % 10;
//     bool result = firstDigit == fifthDigit && secondDigit == fourthDigit;
//     return result;
// }  

// int number = GetIntUserInput("Введите любое целое пятизначное число");

// Console.WriteLine(IsItPalindrome(number) ? $"{number} -> да" : $"{number} -> нет");


Console.WriteLine("Input the number");
int number = Convert.ToInt32(Console.ReadLine());

    bool IsPalindrome(int number){
      // Введите свое решение ниже
      
      bool IsValueInRange(int num)
      {
          int numb;
          if (num < 0) numb = num * -1;
          else numb = num;
          return numb >= 10_000 && numb < 100_000;
      }
      
      bool IsItPalindrome(int x)
      {
          int firstDigit = x / 10_000;
          int secondDigit = x / 1000 % 10;
          int fourthDigit = x / 10 % 10;
          int fifthDigit = x % 10;
          bool result = firstDigit == fifthDigit && secondDigit == fourthDigit;
          return result;
      }  
      
      if (!IsValueInRange(number))
      {
        Console.WriteLine($"{number} -> Число не пятизначное");
        //Console.WriteLine($"{IsValueInRange(number)}, 5");
        return false;
      }
      else
      {
        bool res = IsItPalindrome(number);
        //Console.WriteLine($"{number} -> {result}");
        return res;
      }
      
    }

//Console.WriteLine($"{number}");
bool result = IsPalindrome(number);
Console.WriteLine($"{number} -> {result}");