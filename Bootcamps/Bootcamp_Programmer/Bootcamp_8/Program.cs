// int sunnNumbers(int a, int b)
// {
//     if (b == 0)
//     {
//         return a;
//     }
//     else
//     {
//         return sunnNumbers(a+1,b-1);
//     }
// }
// Console.Clear();
// Console.Write("Введите число:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число:");
// int b = int.Parse(Console.ReadLine());
// System.Console.WriteLine($"{a} + {b} = {sunnNumbers(a,b)}");


/*
[3, -10, 0, 2, -1, 9, 4, 5, 3]
pivot = 3
[-10, 0, 2, -1] + [3, 3] + [9, 4, 5]
pivot = -10
[] + [-10] + [0, 2, -1]
pivot = 0
[-1] + [0] + [2]
pivot = 9
[4, 5] + [9] + []
pivot = 4
[] + [4] + [5]

[-10] + [-1] + [0] + [2] + [3, 3] + [4] + [5] + [9]
*/


// Console.Clear();
// int[] array = {3, -10, 0, 2, -1, 9, 4, 5, 3};
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array, 0, 8))}]");

// int[] quickSort(int[]array, int leftIndex, int rightIndex)
// {
//     int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
//     while (i <=j)
//     {
//         while(array[i] < pivot)
//         {
//             i++;
//         }
//         while(array[j] > pivot)
//         {
//             j--;
//         }
//         if (i <= j)
//         {
//             int temp = array[i];
//             array[i]=array[j];
//             array[j]=temp;
//             i++;
//             j--;
//         }
//     }
//     if (leftIndex < j)
//         quickSort(array, leftIndex, j);
//     if (i < rightIndex)
//         quickSort(array, i, rightIndex);
//     return array;
// }