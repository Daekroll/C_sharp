// string lastPlayer = "White";
// int win = new Random().Next(0,2);
// int round = 0;
// while (round < 10)
// {;
// if (lastPlayer == "White")
// {
//     if (win == 1)
//     {
//         lastPlayer = "White";
//         win = new Random().Next(0,2);
//     }
//     else
//     {
//         lastPlayer = "Black";
//         win = new Random().Next(0,2);
//     }
// }
// else
// {
//     if (win == 1)
//     {
//         lastPlayer = "Black";
//         win = new Random().Next(0,2);
//     }
//     else
//     {
//         lastPlayer = "White";
//         win = new Random().Next(0,2);
//     }
// }
// round++;
// }
// Console.WriteLine(lastPlayer);


// string WhoseMove(string LastPlayer, bool win)
// {
//     if ((LastPlayer == "white") && (win == true))
//     {
//         LastPlayer = "white";
//     }
//     else if ((LastPlayer == "white") && (win == false))
//     {
//         LastPlayer = "black";
//     }
//     else if ((LastPlayer == "black") && (win = true))
//     {
//         LastPlayer = "black";
//     }
//     else if ((LastPlayer == "black") && (win == false))
//     {
//         LastPlayer = "white";
//     }
//     return LastPlayer;
// }
// string result = WhoseMove("white", false);
// Console.WriteLine(result);



// Пример с сайта


namespace Example;

public struct Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Application
{
    static void Main()
    {
        // Create  struct instance and initialize by using "new".
        // Memory is allocated on thread stack.
        Person p1 = new Person("Alex", 9);
        Console.WriteLine("{0}s age is = {1}", p1.Name, p1.Age);

        // // Create  new struct object. Note that  struct can be initialized
        // // without using "new".
        // Person p2 = p1;

        // // Assign values to p2 members.
        // p2.Name = "Spencer";
        // p2.Age = 7;
        // Console.WriteLine("p2 Name = {0} Age = {1}", p2.Name, p2.Age);

        // // p1 values remain unchanged because p2 is  copy.
        // Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);
    }
}
/*
    Output:
    p1 Name = Alex Age = 9
    p2 Name = Spencer Age = 7
    p1 Name = Alex Age = 9
*/




// Задание с сайта

// namespace Solution 
// {
//   using NUnit.Framework;
//   using System;

//   [TestFixture]
//   public class Person_Class_Test
//   {
//     [Test, Description("Should create a Person and have a getter for the Info property")]
//     public void Test()
//     {
//       Person john = new Person("john", 34);
//       Assert.AreEqual("johns age is 34", john.Info);
//     }
//   }
// }

// public class Person
// {  
//     public string Name;
//     public int Age;
//   public Person(string name, int age)
//   {
//     Name = name;
//     Age = age;
//   }
// }




