// int num = new Random().Next(14);
// Console.WriteLine(num);
// var Week = new Dictionary<int, string>()
// {
//     {1, "Понедельник"},
//     {2, "Вторник"},
//     {3, "Среда"},
//     {4, "Четверг"},
//     {5, "Пятница"},
//     {6, "Субботу"},
//     {7, "Воскресенье"},
// };

// bool day = Week.ContainsKey(num);
// if (day)
// {
//     if(Week[num] == "Субботу" || Week[num] == "Воскресенье")
//     {
//         Console.WriteLine("Урааа выходной!!!");
//     }
//     else
//     {
//         Console.WriteLine("Поработаем еще");
//     }
// }
// else
// {
//     Console.WriteLine("Это не день недели");
// }

// string str = "abcdefg";

// System.Console.WriteLine(str.Substring(1, str.Length - 2));

// int[] a = {1, 6, 3, -7, 18};

// System.Console.WriteLine(a.Min());

// Калькуляционный метод через switch

// double basicOp(char operation, double value1, double value2)
//     {
//      double result;
//       switch(operation)
//         {
//           case '+':
//           result = value1 + value2;
//           break;

//           case '-':
//           result = value1 - value2;
//           break;

//           case '/':
//           result = value1 / value2;
//           break;

//           case '*':
//           result = value1 * value2;
//           break;

//           default:
//           result = 0;
//           break;
//       }
//       return result;
//     }
// System.Console.WriteLine(basicOp('+', 19, 38));


// Вывод инициалов имени.


//     string name = "John Veek";
//     //get the index of the space
//     int posOfSpace = name.IndexOf(" ");

//     //build a string with the first character, the period, and the first character AFTER the space
//     string abbrevName = name.Substring(0, 1) + "." + name.Substring(posOfSpace+1, 1);

//     //return the result in uppercase (since some random testcases had lowercase names)
//     System.Console.WriteLine(posOfSpace);
//     System.Console.WriteLine(abbrevName);

// long n = 98732;
// long[] Digitize(long n)
// {
// List<long> answer = new List<long>();
// string stringDigit = n.ToString();
// for(int i = stringDigit.Length - 1; i >= 0; i--)
// {
// answer.Add(stringDigit[i] - '0');
// }
// return answer.ToArray();
// }
// Digitize(n);
// System.Console.WriteLine(n);

// int[] numbers = new int[] {1, 2, 5, 16, 60, 3};



// int[][] data = new[] { new int[] { 45, 12 }, new int[] { 55, 21 }, new int[] { 19, 2 }, new int[] { 104, 20 }};
// string opn = "Open";
// string cls = "Senior";
// string[] member = new string[data.Length];
// for (int i = 0; i < data.Length; i++)
//     {

//         if (data[i][0] >= 55 && data[i][1] >= 7) member[i] = cls;
//          else member[i] = opn;
//     }


// void Print(string[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             System.Console.Write($"{array[i]} ");
//         }
//     }

// Print(member);

// long num1 = 15241383936;
// double num3 = Math.Sqrt(num1);
// double num4 = Math.Pow(num3+1, 2);
// long num2 = ToLong.Parse(num4);
// System.Console.WriteLine(num2);
// long num = 1423281309009358681;
// long num2 = 0;
// double num1 = Math.Sqrt(num);
// long num3 = Convert.ToInt64(num1);
// double num5 = Math.Pow(num1+1, 2);
// long num6 = Convert.ToInt64(num5);
// System.Console.WriteLine(num6);
// System.Console.WriteLine(num5);
// if (num1 == num3)
//   {
//   num2 = Convert.ToInt64(Math.Pow(num1+1, 2));
//    System.Console.WriteLine(num2);
//   }
// else 
//   {
//   System.Console.WriteLine(-1);
//   }

// double vIn = 5.4;
// long vOut = Convert.ToInt64(vIn);
// // 15241630849
// System.Console.WriteLine(vOut);
using System;

int n = 80;
int num = 4;
double res = 1.00;
    for (int i = 1; i < n; i++)
      {
        res+=(double)1/num;
        num+=3;
      }

double res2 = (Math.Round(res, 3));

string res1 = Convert.ToString(res2);
string res4 = String.Empty;
for (int i = 0; i < res1.Length-1; i++)
{
    res4+=res1[i];
}
System.Console.WriteLine(res4);