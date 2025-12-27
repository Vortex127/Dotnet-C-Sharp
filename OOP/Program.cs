using System;
using System.Dynamic;
using System.Net;

namespace PublicExample
{
    // public class example Program

    // class Rectangle
    // {
    //     public double length;
    //     public double width;

    //     public double getArea()
    //     {
    //         return length * width;
    //     }

    //     public void Display()
    //     {
    //         Console.WriteLine($"Length: {length}");
    //         Console.WriteLine($"Width: {width}");
    //         Console.WriteLine($"Area: {getArea()}");
    //     }
    // }

    // class ExecuteRectangle
    // {
    //     static void Main(string[] args)
    //     {
    //         Rectangle r = new Rectangle();
    //         r.length = 10;
    //         r.width = 5;
    //         r.Display();
    //         Console.ReadLine();
    //     }
    // }

    // private example below:
    // class Rectangle
    // {
    //     private double length;
    //     private double width;

    //     public void AcceptDetails()
    //     {
    //         Console.WriteLine("Enter Length: ");
    //         length = Convert.ToDouble(Console.ReadLine());
    //         Console.WriteLine("Enter Width: ");
    //         width = Convert.ToDouble(Console.ReadLine());
    //     }

    //     public double GetArea()
    //     {
    //         return length * width;
    //     }

    //     public void Display()
    //     {
    //         Console.WriteLine($"Length: {length}");
    //         Console.WriteLine($"Width: {width}");
    //         Console.WriteLine($"Area: {GetArea()}");
    //     }
    // }

    // class ExecuteRectangle
    // {
    //     static void Main(string[] args)
    //     {
    //         Rectangle r = new Rectangle();
    //         r.AcceptDetails();
    //         r.Display();
    //         Console.ReadLine();
    //     }
    // }

    class Shapes
    {
        public string? name { get; set; } // Made nullable to avoid warning if not initialized
    }

    class Person
    {
        public string Name { get; set; } // Non-nullable property

        // Constructor to initialize the Name property
        public Person()
        {
            Name = "Default Name"; // Initialize with a default value
        }

        public void ChangePerson(Person p) //if public isn't defined then by default it's private
        {
            p.Name = "Sudhir"; // modifies same object
        }

    }

    class Exec
    {
        static void Main(string[] args)
        {
            Shapes s = new Shapes();
            s.name = "Square";
            Console.WriteLine(s.name);
            Person p = new Person(); // Now the constructor initializes Name
            p.Name = "Ali";
            Console.WriteLine(p.Name);
            p.ChangePerson(p);
            Console.WriteLine(p.Name);
            GetSetOption o = new GetSetOption();
            o.Nname = ""; // Changed from "" to a valid string to avoid ArgumentException
            Console.WriteLine(o.Nname);
        }
    }

        class GetSetOption
        {
            private string name; // Non-nullable field

            // Constructor to initialize the private 'name' field
            public GetSetOption()
            {
                name = "Default"; // Initialize with a default value
            }

            public string Nname
            {
                get => name;
                set => name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Name cannot be null or whitespace.");
            }
        }
    }