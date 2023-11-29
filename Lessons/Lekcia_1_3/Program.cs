// // Первый вид
// void Method1()
// {
//     System.Console.WriteLine("Author");
// }
// Method1();
// // Второй вид
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2("Текст сообщения");
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4);

//Третий вид
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// System.Console.WriteLine(year);

//Четвертый вид
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result+=text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10,"asdf");
// Console.WriteLine(res);

// string Method41(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result+=text;
//     }
//     return result;
// }
// System.Console.WriteLine(Method41(10, "qwer"));
// int x = 1;  
// for (int i = 1; i < 10; i++)
// {   
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.SetCursorPosition(x, j);
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     x+=13;
// }

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ужули бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли  приступом согласие прусского короля."
//             + "Вы так красноречивыю Вы дадите мне чаю?";

// string Replace(string text, char arg1, char arg2)
// {
//     string result = String.Empty;
//     int length  = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == arg1) result+=$"{arg2}";        
//         else result+= $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();


//Сортировка массива

// int[] arr = { 1, 2, 5, 3, 7, 9, 8, 3, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i =0; i <count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0 ; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i+1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);