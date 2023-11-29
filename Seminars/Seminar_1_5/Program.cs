// Задача 1.

// int sumPosNum = 0;
// int sumNegNum = 0;

// void CreateArray()
// {
//     int[] array = new int[12];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//         Console.Write(array[i]+ " ");

//         if (array[i] > 0)
//         {
//             sumPosNum+=array[i];
//         }
//         else
//         {
//             sumNegNum+=array[i];
//         }
//     }
//     Console.WriteLine($"\nСумма положительных чисел = {sumPosNum}, а отрицательных = {sumNegNum}");
// }

// CreateArray();


// Задача 2


// void CreateArray()
// {
//     int[] array = new int[]{-4, -8, 8, 2, -12};
// for (int j = 0; j < array.Length; j++)
//     {  
//         // array[i] = new Random().Next(-9, 10);
//         System.Console.Write(array[j]+ " ");
//     }

//     System.Console.WriteLine();

//     for (int i = 0; i < array.Length; i++)
//     {  
//         // array[i] = new Random().Next(-9, 10);
//         array[i]*=-1;
//         System.Console.Write(array[i]+ " ");
//     }
    
// }
// CreateArray();


// Задача 3.

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// bool isFind = false;

//  void CreateArray()
// {
//     int[] array = new int[9];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//         Console.Write(array[i]+ " ");

//         if (array[i] == num)
//         {
//             isFind = true;
//         }
//     } 
//     if (isFind)
//     {
//         System.Console.WriteLine("Да");
//     }
//     else
//     {
//         System.Console.WriteLine("Нет");
//     }
// }

// CreateArray();

// Задача 4.

// int count = 0;

//  void CreateArray()
// {
//     int[] array = new int[123];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 105);
//         Console.Write(array[i]+ " ");

//         if (array[i] > 9 && array[i] < 100)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine();
//     Console.WriteLine("Кол. = " + count);
// }

// CreateArray();

// Задача 5.



// void CreateArray()
// {
//     int[] array = new int[5];
//     int[] array2 = new int[array.Length/2 + array.Length%2];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//         Console.Write(array[i]+ " ");

//     }
//     System.Console.WriteLine();
//     for (int i = 0; i < array2.Length; i++)
//     {
//         array2[i] = array[i] * array[array.Length -1 -i];
//         if (i == array.Length -1 -i)
//         {
//             array2[i] = array[i];
//         }
//         Console.Write(array2[i]+ " ");
//     }
// }

// CreateArray();