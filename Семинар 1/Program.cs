Console.Clear();

// Возведение в квадрат

// Console.Write("Введите число-> ");
// int usernumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень-> ");
// int userx = Convert.ToInt32(Console.ReadLine());

// double result =  Math.Pow(usernumber, userx);

// Console.Write("Результат: ");
// Console.WriteLine(usernumber + "^" + userx + " = " + result);

// Проверка квадрата

// Console.Write("Введите число-> ");
// int usernumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите квадрат числа-> ");
// int userx = Convert.ToInt32(Console.ReadLine());

// double x =  Math.Pow(usernumber, 2);
// if (userx == x)
// {
//     Console.WriteLine("Все верно");
// }

// else 
// {
//    Console.WriteLine("Это число не является квадратом " + usernumber); 
// }

// Выведение дней недели

// Console.Write("Введите число-> ");
// int usernumber = Convert.ToInt32(Console.ReadLine());

// if (usernumber == 1)
// {
//     Console.WriteLine("Понедельник");
//     }

// else if (usernumber == 2)
//     {
//         Console.WriteLine("Вторник");
//         }

// else if (usernumber == 3)
//     {
//         Console.WriteLine("Среда");
//         }

// else if (usernumber == 4)
//     {
//         Console.WriteLine("Четверг");
//         }

// else if (usernumber == 5)
//     {
//         Console.WriteLine("Пятница");
//         }

// else if (usernumber == 6)
//     {
//         Console.WriteLine("Суббота");
//         }

// else if (usernumber == 7)
//     {
//         Console.WriteLine("Воскресенье");
//         }

// else 
//     {
//         Console.WriteLine("Такого дня недели нет");
//         }

// Задача написать код пока не получиться так:
// Ввели 5
// В консоли: -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5


// Console.Write("Введите число-> ");
// int usernumber = Convert.ToInt32(Console.ReadLine());
// int negnum = usernumber * -1;

// if (negnum < 0)
//  {   while (negnum <= usernumber)
// {
//         Console.Write(negnum + ", ");
//         negnum++;
// }
//  }

// else if (negnum > 0) 
//     {
//     while (negnum >= usernumber)
//         {   
//         Console.Write(usernumber + ", ");
//         usernumber++;
//         }
//     }

// Задача выделить 3 цифру 3-х значтоного числа

// Console.Write("Введите число-> ");
// int usernumber = Convert.ToInt32(Console.ReadLine());

// if (usernumber < 100)
// {
//     Console.Write("Введите другое число");
// }    

// else if (usernumber > 999)
// {
//     Console.Write("Введите другое число");
// }

// else 
// {
//     int result = usernumber % 10;
//     Console.Write(result);
// }