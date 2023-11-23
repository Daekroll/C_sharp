// Console.WriteLine("Введите число");
// int count = 0;
// int n = Convert.ToInt32(Console.ReadLine());
// int mem = n;
// while (n > 1)
// {
//     if (n% 2 == 1)
//     {
//         n = n * 3 + 1;
//         count++;
//     }
//     else
//     {
//         n = n / 2;
//         count++;
//     }

// }

// Console.WriteLine($"Количество итераций до ззначения 1 для числа {mem} = {count}");



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

// Console.WriteLine("Введите длину строки");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,] array1 = CreateArray(rows, columns);
// PrintArray(array1);
// int[,] array2 = ArraySort(array1);
// PrintArray(array2);

// int[,] CreateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(-10,50);
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

// int[,] ArraySort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             for (int j = 1; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] < array[i, j - 1])
//                 {
//                     temp = array[i, j - 1];
//                     array[i, j - 1] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }


// int[,] matrixA = 
// {
//     {1,2},
//     {3,4},
// };
// int[,] matrixB = 
// {
//     {5,6},
//     {7,8},
// };
// // 0,0 * 0,0 + 0,1*1,0
// // 0,0 * 0,1 + 0,1*1,1 
// // 1,0 * 0,0 + 1,1* 0,1
// // 1,0 * 0,1 + 1,1* 1,1
// int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
// for (int i = 0; i < matrixA.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixB.GetLength(1); j++)
//     {
//         for (int k = 1; k < matrixB.GetLength(1); k++)
//         {
//             matrixC[i,j] = matrixA[i,0]*matrixB[0,j]+matrixA[i,k]*matrixB[k,j];
//             System.Console.WriteLine($"{i},{i} {i},{j} {i},{k} {k},{j}");
//         }
//     }
// }
// PrintArray(matrixC);

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
// }


// int[,] matrixA = 
// {
//     {2,2},
//     {2,2},
//     {2,2},
// };
// int[,] matrixB = 
// {
//     {2,2,2},
//     {2,2,2},
// };

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
//     {       
//         if (matrixA.GetLength(1) != matrixB.GetLength(0))
//         {
//             throw new Exception("It is impossible to multiply.");
//         }
//         int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//         for (int i = 0; i < matrixA.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrixB.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrixA.GetLength(1); k++)
//                 {
//                     matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
//                 }
//             }
//         }
//         return matrixC;
//     }
// int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
// PrintArray(matrixC);

