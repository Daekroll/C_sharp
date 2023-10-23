// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int Sum(int A)
// {
//     int result = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         result+=i;
//     }
//     return result;
// }
// int res = Sum(num);
// System.Console.WriteLine(res);

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetCount(int A)
// {
//     int count = 0;
//     int result = A;
//     while (result > 0)
//     {
//         result = result / 10;
//         count++;
//     }
//     return count;
// }

// int res = GetCount(num);
// System.Console.WriteLine(res);



// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int Pos(int A)
// {
//     int result = 1;
//     for (int i = 1; i <= A; i++)
//     {
//         result = result*i;
//     }
//     return result;
// }
// int res = Pos(num);
// System.Console.WriteLine(res);


void CreateArray()
{
    int[] arr = new int[8];
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = new Random().Next(0,2);
        System.Console.Write($"{arr[i]} ");
        i++;
    }
}

CreateArray();
