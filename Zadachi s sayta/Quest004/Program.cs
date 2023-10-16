public class Person
{  
  public string name;
  public int age;
  public string Info => $"{name}s age is {age}";

  public Person(string name, int age)
  {
    this.name = name;
    this.age = age;
  }
}