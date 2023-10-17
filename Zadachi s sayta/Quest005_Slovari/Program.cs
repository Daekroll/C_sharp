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

string str = "abcdefg";

System.Console.WriteLine(str.Substring(1, str.Length - 2));
