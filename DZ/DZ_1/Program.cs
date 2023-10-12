// Console.WriteLine("Введите первое число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Первое число " + " `" + firstNumber + "` больше чем второе число `" + secondNumber + "`");
// }
// else if (firstNumber < secondNumber)
// {
//     Console.WriteLine("Первое число `" + firstNumber + "` меньше чем второе число `" + secondNumber + "`");
// }
// else
// {
//     Console.WriteLine("Введенные числа равны `" + firstNumber + "`");
// }


int a = 9;
int b = 9;
int c = 5;
int result = 0;
    if (a > b)
    {
      if (a > c)
      {
        result = a;
      }
        else
      {
        result = c;
      }
    }
    else if (b > c)
    {
      result = b;
    }
      else
    {
        result = c;
    }
Console.Write(result);