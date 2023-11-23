// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int startNum = 1;
// string PrintNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start+ " "+ PrintNumbers(start+1, end));
// }
// System.Console.WriteLine(PrintNumbers(startNum, n));

// System.Console.WriteLine("Введите число");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m>n)
// {
//     System.Console.WriteLine(PrintNumbers(n, m));
// }
// else if(n>m)
// {
//     System.Console.WriteLine(PrintNumbers(m, n));
// }
// else 
// {
//     System.Console.WriteLine("Числа равны");
// }
// string PrintNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start+ " "+ PrintNumbers(start+1, end));
// }



// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());


// int PrintNumbers(int start)
// {
//     if (start == 0)
//     {
//         return 0;
//     }

//     return (start%10+PrintNumbers(start/10));
// }
// System.Console.WriteLine(PrintNumbers(n));


System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());

int Pow(int num, int runk)
{
    if (runk == 0)
    {
        return 1;
    }
    if (runk == 1)
    {
        return num;
    }
    return (num*Pow(num, runk-1));
}
System.Console.WriteLine(Pow(a, b));