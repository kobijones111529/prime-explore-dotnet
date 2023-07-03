Console.WriteLine(Multiples.Solution(7));

// Make a string
String name = "Kobi";
Console.WriteLine($"Hello, {name}!");

// Make a number
int number = 42;
Console.WriteLine($"{number} is a cool number.");

// Make a boolean
bool boolean = false;
Console.WriteLine($"JavaScript is{(boolean ? "" : " not")} the best language.");

// Make an if / else if / else block
string? str = Console.ReadLine();
if (str == null)
{
  Console.WriteLine("Rude.");
}
else if (str == "Hi!")
{
  Console.WriteLine("Hello!");
}
else
{
  Console.WriteLine("K.");
}

// Make a switch block
switch (str)
{
  case null:
    {
      Console.WriteLine("Rude.");
      break;
    }
  case "Hi!":
    {
      Console.WriteLine("Hello!");
      break;
    }
  case "Hello!":
    {
      Console.WriteLine("Hi!");
      break;
    }
  default:
    {
      Console.WriteLine("K.");
      break;
    }
}

// Make a for loop
string[] strings = { "A one", "And a two", "And a three" };
for (int i = 0; i < strings.Length; i++)
{
  Console.WriteLine(strings[i]);
}

// Make a foreach loop
foreach (string strButCSharpDoesntHaveShadowing in strings)
{
  Console.WriteLine(strButCSharpDoesntHaveShadowing);
}

// Use a list instead of an array
List<string> list = new List<string> { "Hi", "Hello", "Hola" };
foreach (string strAgain in list)
{
  Console.WriteLine(strAgain);
}

// Intantiate a class
Class cls = new Class(new List<string> { "Kobi" });
// Call from instance of class
int studentsShown = cls.showStudents();

// Make an array of objects
Class[] classes = { new Class(new List<string> { "Kobi" }), new Class(new List<string> { "Kobi 2 Electric Boogaloo", "Kob3" }) };

// Loop over array of objects
foreach (Class clsInClasses in classes) {
  clsInClasses.showStudents();
}

// Make a class
class Class
{
  public List<string> students;

  public Class(List<string> students)
  {
    this.students = students;
  }

  // Make a method
  public int showStudents()
  {
    foreach (string student in students)
    {
      Console.WriteLine(student);
    }
    // Return a value
    return students.Count;
  }
}
