using System; // Importing the System namespace to use Console class

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");
      // Console.Write("Wssup\n"); // doesn't go to next line
      // int age = 20; // double, bool, char, string
      // Console.WriteLine("I am " + age + " years old.");
      // const string responsibilties = "carry";
      // Console.WriteLine("My responsibilties are to " + responsibilties);
      // long myNum = 15000000000L;
      // Console.WriteLine(myNum);
      // float myNum1 = 5.75F;
      // Console.WriteLine(myNum1);
      // double myNum2 = 19.99D;
      // Console.WriteLine(myNum2);
      // float f1 = 35e3F; // e3 means power of 3
      // double d1 = 12E4D; // likewise here, it's 4
      // Console.WriteLine(f1);
      // Console.WriteLine(d1);

      // Console.WriteLine("Enter you username: ");
      // string userName = Console.ReadLine(); //read line returns a string so to take any non-string input, we have to explicitly typecast it
      // Console.WriteLine("Hello " + userName);

      Console.WriteLine("Enter your name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Hello " + name + ". You are " + age + " years old.");
    }
  }
}