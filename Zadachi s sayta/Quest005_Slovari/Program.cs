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