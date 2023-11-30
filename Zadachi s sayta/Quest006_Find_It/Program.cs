// int[] seq = {20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5,5,9};

// int find_it(int[] seq) 
//       {
//       int min = seq[0];
//       int max = seq[0];
//       for (int i = 1; i < seq.Length; i++)
//         {
//           if (seq[i] < min)
//             {
//               min = seq[i];
//             }
//           if (seq[i] > max)
//             {
//               max = seq[i];
//             }
//         }
//       int[,] array = new int[2,100];
//       int index = 0;
//       for(int i = min; i <= max; i++)
//         {
//         int count = 0;
//         for (int j = 0; j < seq.Length; j++)
//           {
//           if (seq[j] == i)
//             {
//               count++;
//             }
//           }
//           array[0,index]=i;
//           array[1,index]=count;
//           count = 0;
//           index++;
//         }
//         int res = 0;
//         for (int i = 0; i < array.GetLength(1); i++)
//           {
//             if (array[1,i]%2 == 1)
//               {
//                 res = array[0,i];
//               }
//           }
//       return res;
//       }
// int res = find_it(seq);
// Console.WriteLine(res);

// long n = 999999999999;

// int SumDigits(long n)
// {

// long r = 0;
// while (n > 9)
// {
//     r=n%10;
//     n/=10;
//     n+=r;
// }
// int res = (int) n;
// return res;
// }
// int res = SumDigits(n);
// Console.WriteLine(res);

// using System.Security.Principal;

// int[] a = {5,6,1,3,2,2,3,1,5};
// PrintArray(a);
// int[] b = {1,2,3,4,2,3,1,2};
// PrintArray(b);
// for (int i = 0; i < b.Length; i++)
// {
//     a = a.Where(e => e != b[i]).ToArray();
// }

// using System.Runtime.CompilerServices;

// int number = 1234;
// string bit = Convert.ToString(number, 2);
// int count = 0;
// for (int i = 0; i < bit.Length; i++)
// {
//     if (bit[i] == '1')
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);
// Console.WriteLine(bit);
// int[] integers = {2,6,8,-10,3};

// int count = 0;
// int number = 0;
// for (int i = 0; i < 2; i++)
// {
//     if (integers[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// if (count > 1)
// {
//     for (int i = 0; i < integers.Length; i++)
//     {
//         if (integers[i] % 2 != 0)
//         {
//             number = integers[i];
//         }
//     }
// }
// if (count < 2)
// {
//     for (int i = 0; i < integers.Length; i++)
//     {
//         if (integers[i] % 2 == 0)
//         {
//             number = integers[i];
//         }
//     }
// }
// System.Console.WriteLine(count);
// System.Console.WriteLine(number);
// int[] arr = {1, 2, 0, 1, 0, 1, 0, 3, 0, 1};

// int temp = 0;
// for (int j = 0; j < arr.Length; j++)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         if (arr[i] == 0)
//         {
//             if (arr[i+1] != 0)
//             {
//                 temp = arr[i + 1];
//                 arr[i + 1] = arr[i];
//                 arr[i] = temp;
//             }
//         }
//     }
// }

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }


long n = 1;
System.Console.WriteLine(n);
for (int i = 0; i <= 57; i++)
{
    n = n*2;
}
System.Console.WriteLine(n);