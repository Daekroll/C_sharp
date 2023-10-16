// Console.WriteLine("Введите размерность массива");
// int rown = Convert.ToInt32(Console.ReadLine());

// int num = new Random().Next(10, 100);

// int num1 = num / 10;
// int num2 = num % 10;
// Console.WriteLine(num);
// if(num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int num1 = num / 100;
// int num2 = num % 10;
// int result = num1*10 + num2;

// Console.WriteLine(result);


// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
//     {
//         if(num1%num2 == 0)
//         {
//             Console.WriteLine($"Число {num1} кратно числу {num2}");
//         }
//         else
//         {
//             Console.WriteLine($"Число {num1} не кратно {num2}, остаток от деления {num1%num2}");
//         }
//     }
// else
// {
//     if (num2%num1 == 0)
//     {
//         Console.WriteLine($"Число {num2} кратно числу {num1}");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num2} не кратно {num1}, остаток от деления {num2%num1}");
//     }
// }    

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num%7 == 0 && num%23 == 0)
{
    Console.Write($"{num} -> Yes");
}
else
{
    Console.WriteLine($"{num} -> No");
}