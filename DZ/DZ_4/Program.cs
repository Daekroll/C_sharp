
// Задача 1.
// Вариант 1.

// Console.WriteLine("Введите количество чисел");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// Console.WriteLine("Введите свои числа");
// for (int i = 0; i < num; i++)
// {
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     if (num1 > 0) count++;
// }
// Console.WriteLine($"Чисел больше нуля: {count}");

// Вариант 2.

// string instruction = "Приветствуем в программе подсчета чисел больше нуля!"
//                     + " Вводите свои числа нажимая Enter,"
//                     + " когда решите закончить введите End";
// System.Console.WriteLine(instruction);

// int count = 0;

// void CountNumbers()
// {
//     Console.WriteLine("Введите число");
//     string text = Console.ReadLine().ToLower();
//     if (text == "end") return;
//     else 
//     {
//     int num = Convert.ToInt32(text);
//     if (num > 0) count++;
//     CountNumbers();
//     }
// }

// CountNumbers();

// System.Console.WriteLine($"Колтчесьво чисел больше нуля: {count}");

// Вариант 3.

// System.Console.WriteLine("Вводите числа, когда закончите - напишите \"end\"");

// int count = 0;
// bool inOut = true;

// while(inOut)
// {
//     string text = Console.ReadLine();
//     inOut = int.TryParse(text, out int number);
//     if(inOut)
//         {
//             if(number > 0) count++;
//         }
//     else if (text.ToLower() == "end")
//     {
//         Console.WriteLine($"Количество чисел больше нуля: {count}");
//         inOut = false;
//     }    
//     else 
//     {
//         System.Console.WriteLine("Введена некорректная команда,\nвведите число чтобы продожить,\nили \"end\" для выхода.");
//         inOut = true;
//     }
// }

// Задачв 2.

// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// System.Console.WriteLine("Введите 4 числа");
// double b1 = Convert.ToDouble(Console.ReadLine());
// double k1 = Convert.ToDouble(Console.ReadLine());
// double b2 = Convert.ToDouble(Console.ReadLine());
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2-b1)/(k1-k2);
// double y = k1 * x + b1;

// double res1 = Math.Round(y,1);
// double res2 = Math.Round(x,1);

// System.Console.WriteLine($"{res1}; {res2};");
