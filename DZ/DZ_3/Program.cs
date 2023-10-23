// // Задание 1


// System.Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите степень");
// int num2 = Convert.ToInt32(Console.ReadLine());

// double PowNumber1(int a, int b)
// {
//     return Math.Pow(a, b);
// }

// double PowNumber2(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result*=a;
//     }
//     return result;
// }

// System.Console.WriteLine(PowNumber1(num1,num2));
// System.Console.WriteLine(PowNumber2(num1,num2));

// Задание 2

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumCharNumber(int a)
// {
//     int result = 0;
//     while (a > 0)
//     {
//         result+=a%10;
//         a/=10;
//     }
//     return result;
// }

// System.Console.WriteLine(SumCharNumber(num));


// Задание 3


// System.Console.WriteLine("Введите размер массива");
// int range = Convert.ToInt32(Console.ReadLine());

// void CreateArray(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 50);
//         Console.Write($"{arr[i]} ");
//     }
// }

// CreateArray(range);