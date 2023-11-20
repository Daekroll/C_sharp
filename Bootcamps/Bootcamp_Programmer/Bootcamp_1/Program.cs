// 0 1 2 3 4 5 6 7 8 9 
// 4 6 1 4 7 9 2 4 6 1
// 1. Создание массива
// 2. Заполнить массив
//     -руками
//     -случайно
//     -из файла
// 3. Печать массива
// 4. Сумма
// 5. Печать результата
//     -в консоль
//     -в файл

using System.Diagnostics;

int[] array = 10_000_000.Create()
                .Fill(1, 10);
// array.ConvertToStringAndPrintToTerminal();


int max;
int m = 100_000;
Stopwatch sw = new Stopwatch();
sw.Start();
max = array.BadGetSum(m);
sw.Stop();

Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");