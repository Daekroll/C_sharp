// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// System.Console.WriteLine("Введите число"); // Запрашиваем число у пользователся
// int n = Convert.ToInt32(Console.ReadLine()); // Считываем число из терминала
// int end = 1;
// string PrintNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         return end.ToString();
//     }
//     return (start+ " "+ PrintNumbers(start-1, end));
// }
// Console.WriteLine(PrintNumbers(n, end));



// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// System.Console.WriteLine("Введите число"); // Запрашиваем число у пользователся
// int m = Convert.ToInt32(Console.ReadLine()); // Считываем число из терминала
// System.Console.WriteLine("Введите число"); // Запрашиваем число у пользователся
// int n = Convert.ToInt32(Console.ReadLine()); // Считываем число из терминала
// int i = 0;
// if (m>n) //Первое введенное число больше
// {
//     Console.WriteLine(SummNumbers(n, m));
// }
// else if (n>m) //Второе введенное число больше
// {
//     Console.WriteLine(SummNumbers(m, n));
// }
// else //Введенные числа равны
// {
//     Console.WriteLine("Числа равны");
// }
// int SummNumbers(int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     return (m + SummNumbers(m+1, n));
// }

// if (m>n) //Первое введенное число больше
// {
//     SummNumbers(n, m, i);
// }
// else if (n>m) //Второе введенное число больше
// {
//     SummNumbers(m, n, i);
// }
// else //Введенные числа равны
// {
//     Console.WriteLine("Числа равны");
// }

// void SummNumbers(int m, int n, int i)
// {
//     i+=m;
//     if (m == n)
//     {
//         Console.WriteLine(i);
//     }
//     else
//     {
        
//         SummNumbers(m+1, n, i);
        
//     } 
// }


// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.


// System.Console.WriteLine("Введите число"); // Запрашиваем число у пользователся
// int m = Convert.ToInt32(Console.ReadLine()); // Считываем число из терминала
// System.Console.WriteLine("Введите число"); // Запрашиваем число у пользователся
// int n = Convert.ToInt32(Console.ReadLine()); // Считываем число из терминала
// int Ack(int n, int m) //Функция аккермана
// {
//     if (n == 0)
//         return m + 1;
//     else if (m == 0)
//     {
//         return Ack(n - 1, 1);
//     }
//     else
//     {
//         return Ack(n - 1, Ack(n, m - 1));
//     }
// }
// System.Console.WriteLine(Ack(m, n));