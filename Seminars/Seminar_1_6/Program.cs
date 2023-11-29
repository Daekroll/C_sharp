// Задача 40: Напишите программу, которая принимает
//  на вход три числа и проверяет, может ли существовать 
//  треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая 
// сторона треугольника меньше суммы двух других сторон.
// || - или && - и

// Console.WriteLine("Введите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число 3");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1<num2+num3 && num2<num1+num3 && num3<num1+num2) Console.WriteLine("Это треугольник");
// else Console.WriteLine("Это не треугольник");

// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// string bin = Convert.ToString(num, 2);
// Console.WriteLine(bin);

// Задача 44: Не используя рекурсию, выведите
//  первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 0;
// int secondNum = 1;
// System.Console.Write($"{firstNum} {secondNum} ");
// for (int i = 3; i <= num; i++)
// {
//     int nextNum = firstNum+secondNum;
//     System.Console.Write($"{nextNum} ");
//     firstNum=secondNum;
//     secondNum=nextNum;
// }

//  Задача 45: Напишите программу, которая будет 
//  создавать копию заданного массива с помощью
//   поэлементного копирования.

// int[] array = new int[]{4,1,92,15};
// int[] array2 = new int[array.Length];

// for (int i = 0; i < array.Length; i++)
// {
//     array2[i]=array[i];
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// PrintArray(array2);

// Задача 39: Напишите программу, которая
//  перевернёт одномерный массив
//   (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

//Размер Массива
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 100);
// }

//  void ArrayReverse(int[] array)
//  {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length-1-i];
//         array[array.Length-1-i] = temp;
//     }
//  }

//  void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// PrintArray(array);
// ArrayReverse(array);
// PrintArray(array);


using System;
using System.Runtime.CompilerServices;

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;
if (num < 1) Console.WriteLine("nothing");
else if (num == 1) Console.WriteLine(a);
else if (num > 2)
{
    Console.Write($"{a} {b} ");
    for (int i = 3; i <= num; i++)
    {   
    int nextNum = a+b;
    System.Console.Write($"{nextNum} ");
    a=b;
    b=nextNum;
    }
}
else Console.Write($"{a} {b} ");