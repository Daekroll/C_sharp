// using System.Reflection;
// using System.Runtime.CompilerServices;

// Console.WriteLine("Введите длину строки");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// int[,] array = CreateArray(rows, columns);
// // PrintArray(array);
// SpireFillArray(rows, columns);
// PrintArray(array);


// int[,] CreateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = 0;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine();
// }

// void SpireFillArray(int rows, int columns,int i = 0, int j = 0)
// {
//     for (int k = j; k < columns; k++)
//     {
//         if (array[i, k] == 0)
//         {
//             array[i, k] = count;
//             count++;
//         }
//         j++;
//     }
//     j--;
//     for (int z = i; z < rows; z++)
//     {
//         if (array[z, j] == 0)
//         {
//             array[z, j] = count;
//             count++;
//         }
//         i++;
//     }
//     i--;
//     for (int k = j; k >= array.GetLength(1)-columns; k--)
//     {
//         if (array[i, k] == 0)
//         {
//             array[i, k] = count;
//             count++;
//         }
//         j--;
//     }
//     j++;
//     for (int z = i; z >= array.GetLength(0)-rows; z--)
//     {
//         if (array[z, j] == 0)
//         {
//             array[z, j] = count;
//             count++;
//         }
//         i--;
//     }
//     i++;
//     System.Console.WriteLine($"i = {i} j = {j}");
//     while (array[array.GetLength(0)/2,array.GetLength(1)/2] == 0)
//     {
//     SpireFillArray(rows -1, columns -1, i+1, j+1);
//     }
// }


// using System.Globalization;
// using System.Security.Principal;

using System;

Console.WriteLine("Введите длину строки");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину массива");
int deep = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int [rows, columns, deep];
FillArray(array);
PrintArray(array);
void FillArray(int[,,] array)
{   
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                bool uniq = true;
                int temp = new Random().Next(10, 100);
               foreach (int num in array)
               {
                    if (num == temp)
                    {
                        uniq = false;
                    }
               }
               if (uniq)
               {
                array[i, j, k] = temp;
               }
               else
               {
                k--;
               }
            }
        }
    }
}

void PrintArray(int[,,] array)
{   string line = "_______________________";
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {  
                Console.Write($"array({i},{j},{k}) = {array[i,j,k]}\t"); 
            }
            Console.WriteLine();
        }
        int count = 0;
        while (count < array.GetLength(2))
        {
        Console.Write(line);
        count++;
        }
        Console.WriteLine();
    }
}

