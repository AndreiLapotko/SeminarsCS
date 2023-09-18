// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
string weeksDay = Console.ReadLine();

if (weeksDay == "1") Console.WriteLine($"{weeksDay} -> Понедельник");
   else if (weeksDay == "2") Console.WriteLine($"{weeksDay} -> Вторник");
   else if (weeksDay == "3") Console.WriteLine($"{weeksDay} -> Среда");
   else if (weeksDay == "4") Console.WriteLine($"{weeksDay} -> Четверг");
   else if (weeksDay == "5") Console.WriteLine($"{weeksDay} -> Пятница");
   else if (weeksDay == "6") Console.WriteLine($"{weeksDay} -> Суббота");
   else if (weeksDay == "7") Console.WriteLine($"{weeksDay} -> Воскресенье");
else Console.WriteLine("Введите корректные данные!");