
// Console.WriteLine("Введите количество чисел");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// Console.WriteLine("Введите свои числа");
// for (int i = 0; i < num; i++)
// {
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     if (num1 > 0) count++;
// }
// Console.WriteLine($"Чисел больше нуля: {count}");

// string instruction = "Приветствуем в программе подсчета чисел больше нуля!"
//                     + " Вводите свои числа нажимая Enter,"
//                     + " когда решите закончить введите End";
// System.Console.WriteLine(instruction);

// int count = 0;

// void CountNumbers()
// {
//     Console.WriteLine("Введите число");
//     string text = Console.ReadLine().ToLower();
//     if (text == "end") return;
//     else 
//     {
//     int num = Convert.ToInt32(text);
//     if (num > 0) count++;
//     CountNumbers();
//     }
// }

// CountNumbers();

// System.Console.WriteLine($"Колтчесьво чисел больше нуля: {count}");


// System.Console.WriteLine("Вводите числа, когда закончите - напишите \"end\"");

// int count = 0;
// bool inOut = true;

// while(inOut)
// {
//     string text = Console.ReadLine();
//     inOut = int.TryParse(text, out int number);
//     if(inOut)
//         {
//             if(number > 0) count++;
//         }
//     else if (text.ToLower() == "end")
//     {
//         Console.WriteLine($"Количество чисел больше нуля: {count}");
//         inOut = false;
//     }    
//     else 
//     {
//         System.Console.WriteLine("Введена некорректная команда,\nвведите число чтобы продожить,\nили \"end\" для выхода.");
//         inOut = true;
//     }
// }
