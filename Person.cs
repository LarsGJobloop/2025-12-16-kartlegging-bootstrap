public class Person
{
  // Information (Properties)
  public string Name;
  public int Age;

  // Konstruktør (Constructor)
  public Person(string name, int age)
  {
    if (name.Count() < 3)
    {
      throw new Exception("Name needs to be atleast 3 characters!");
    }

    Name = name;
    Age = age;
  }

  // Ting vi gjøre med klassen (Metode)
  public string Describe()
  {
    return "Name: " + Name + "    Age: " + Age;
  }
}
