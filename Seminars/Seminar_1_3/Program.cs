using System;
// using System.Reflection.Emit;
// using System.Data;
// using System.Dynamic;
// using Internal;
// using System;
// Console.WriteLine("Input number 1");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number 2");
// int y = int.Parse(Console.ReadLine());

// if(x>0 && y>0)
// {
//     Console.WriteLine("1");
// }
// else if(x<0 && y>0)
// {
//     Console.WriteLine("2");
// }
// else if(x<0 && y<0)
// {
//     Console.WriteLine("3");
// }
// else
// {
//     Console.WriteLine("4");
// }



// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// switch(num)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0, y>0");
//         break;
//     }

//     case 2:
//     {
//         Console.WriteLine("x<0, y>0");
//         break;
//     }

//     case 3:
//     {
//         Console.WriteLine("x<0>, y<0");
//         break;
//     }

//     case 4:
//     {
//         Console.WriteLine("x>0, y<0");
//         break;
//     }

//     default:
//     {
//         Console.WriteLine("Такой четверти нет");
//         break;
//     }

// }

// Console.WriteLine("Input number");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2), 2)));

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     Console.Write(Math.Pow(i, 2) + " ");
// }

// Разворот числа на 180 градусов)

// int reverse = 0;
//         int temp = number;
//         while (temp > 0){
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
// int i = 0;
// int[] myArray = { 1, 2, 3, 4, 5 };
// int itemToRemove = 3;
// Array.Remove(myArray, itemToRemove);

// while (i < myArray.Length)
// {
//     Console.WriteLine(myArray[i]);
// }

// int i = 0;
// List<int> myList = new List<int> { 1, 2, 3, 19, 81, 4, 5 };
// int itemToRemove = 3;
// myList.Remove(itemToRemove);

// while (i < myList.Count)
// {
//     Console.WriteLine(myList[i]);
//     i++;
// }
int i = 0;
int[] s = {3,4,4,3,6,3};
int[] a = s.Reverse().ToArray();
int[] b = a.Distinct().ToArray();
int[] q = b.Reverse().ToArray();
while (i < q.Length)
{
    Console.WriteLine(q[i]);
    i++;
}