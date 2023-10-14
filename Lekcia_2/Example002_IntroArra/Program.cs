// int[] array = {11, 7, 91, 67, 13, 27, 111, 5, 30};

// int Max(int arg1, int arg2, int arg3)
//     {
//         int result = arg1;
//         if (arg2 > result) result = arg2;
//         if (arg3 > result) result = arg3;
//         return result;
//     }

// int max = Max(
// Max(array[0], array[1], array[2]),
// Max(array[3], array[4], array[5]),
// Max(array[6], array[7], array[8])
// );
// Console.WriteLine(max);

// int[] array = {1, 6, 12, 54, 33, 89, 111, 43, 123, 87, 4};

// int n = array.Length;
// int find = 89;
// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
//     {
//         int count = col.Length;
//         int position = 0;
//         while (position < count)
//         {
//             Console.WriteLine(col[position]);
//             position++;
//         }
//     }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array); 
// Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);