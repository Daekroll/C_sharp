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



// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num = new Random().Next(0,999999999);
// Console.WriteLine(num);

// int SumCharNumber(int a)
// {
//     int result = 0;
//     while (a > 0)
//     {
//         result+=a%10;
//         a/=10;
//     }
//     while (result > 9)
//     {
//         int temp = result;
//         result = 0;
//         while (temp > 0)
//         {
//             result+=temp%10;
//             temp/=10;
//         }
//     }
//     return result;
// }

// Console.WriteLine(SumCharNumber(num));

int[] arr = {1, 9, 3, 6, -5};
int count = arr.Length;
int n = 0;
void SortedArray(int[] array)
{
    while (n < count)
    {
        int index = 1;
        int max = array[0];
        int temp = 0;
        while (index < count)
        {
            if (max < array[index])
            {
                temp = max;
                max = array[index];
                array[index-1] = temp;
        
            }
            else
            {
                temp = array[index];
                array[index] = max;
                array[index-1] = temp;
            }    
            index++;
        }
        count--;    
    }    
}

void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.Write($"{col[position]} ");
            position++;
        }
    }

SortedArray(arr);
PrintArray(arr);