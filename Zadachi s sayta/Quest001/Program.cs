Console.WriteLine("Введите число");
int count = 0;
int n = Convert.ToInt32(Console.ReadLine());
int mem = n;
while (n > 1)
{
    if (n% 2 == 1)
    {
        n = n * 3 + 1;
        count++;
    }
    else
    {
        n = n / 2;
        count++;
    }

}

Console.WriteLine($"Количество итераций до ззначения 1 для числа {mem} = {count}");