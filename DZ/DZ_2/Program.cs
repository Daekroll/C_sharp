﻿// Домашнее задание №1. 
// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите число");

// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine((a / 10)% 10);



// Домашнее задание №2

// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Вариант 1: "Ручной ввод"
// // Console.WriteLine("Введите любое число");
// // int num = Convert.ToInt32(Console.ReadLine());

// Вариант 2: "Рандомное число"
// int num = new Random().Next(0, 999999999);



// Console.WriteLine(num);
// if (num < 100)
// {
//     Console.WriteLine("Это число не подходит");
// }
// else if (num > 100 && num < 999)
// {
//     Console.WriteLine(num%10);
// }
// else
// {
//     while(num > 999)
//     {
//         num = num / 10;
//     }
//     Console.WriteLine(num%10);
// }


// Домашнее задание №3
// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 1 && num < 6)
// {
//     Console.WriteLine("Сегодня будний день:(");
// }
// else if(num > 5 && num < 8)
// {
//     Console.WriteLine("Сегодня выходной!!!:D");
// }
// else
// {
//     Console.WriteLine("Такого дня недели нет!-_-");
// }