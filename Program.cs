using System; // Importing the System namespace to use Console class

namespace HelloWorld
{
  class Program
  {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Wssup\n"); // doesn't go to next line
            int age = 20; // double, bool, char, string
            Console.WriteLine("I am " + age + " years old.");
            const string responsibilties = "carry";
            Console.WriteLine("My responsibilties are to " + responsibilties);
        }
  }
}