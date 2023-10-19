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