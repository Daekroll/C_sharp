// using System.Globalization;

// Console.WriteLine("Введите длину строки");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateArray(rows, columns);
// PrintArray(array);
// // ChangeString(array);
// PrintArray(array);

// int[,] CreateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
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

// void ChangeString(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[array.GetLength(0)-1, i];
//         array[array.GetLength(0)-1, i] = array[0,i];
//         array[0,i] = temp;
//     }
// }


// Console.WriteLine("Введите длину строки");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateArray(rows, rows);
// PrintArray(array);

// PrintArray(ChangeRowColumn());
// int[,] CreateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
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
//     Console.WriteLine();
// }

// int[,] ChangeRowColumn()
// {
//     int[,] result = new int[array.GetLength(0),array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[j,i] = array[i,j];
//         }
//     }
//    return result;
// }


Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array= new int[rows,rows];
int minElement= 10;
int minRow= 0;
int minColumn = 0;

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10); //0,9

            if(array[i,j]< minElement)
            {
                minElement= array[i,j];
                minRow= i;
                minColumn = j;
            }
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j]+ "\t");
        }
        System.Console.WriteLine();
    }
}

void ChangeArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i!= minRow && j != minColumn)
            {
                System.Console.Write(array[i,j]+ "\t");
            }
        }
        System.Console.WriteLine();
    }
}

CreateArray();
PrintArray(array);

System.Console.WriteLine();
ChangeArray();
