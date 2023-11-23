// using System;

// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("[" + string.Join(" ", array) + "]");
// // [4, 5, 3, 1, 2]
// //O(n)
// // [1, 2, 3, 4, 5] - O(n*logn)
// //((5+1)/2) * 5 - O(1)
// // n < n * log(n) + 1
// int summ = 0;
// for (int i = 0; i < n; i++)
// {
//     summ+=array[i];
// }
// Console.WriteLine(summ);


int n = int.Parse(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write($"{i*j}\t");
//     }
//     Console.WriteLine();
// }

int[,] matrix = new int[n,n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
            matrix[i,j] = (i+1) * (j+1);
            matrix[j,i] = (i+1) * (j+1);
    }
} 



for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
}