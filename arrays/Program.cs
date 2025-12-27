using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Authentication;

namespace Arrays_Apps
{
//     class Array
//     {
// shallow copy example:
//         public string Name;
//     }

//     class ArrayFuncs
//     {
//         static void Main(string[] args)
//         {
//             Array[] a =
//             {
//                 new Array { Name = "Asfand"},
//                 new Array { Name = "Aman"}
//             };

//             Array[] b = (Array[])a.Clone();
//             b[0].Name = "Ali";

//             Console.WriteLine($"The name is: {b[0].Name}");
//             Console.WriteLine($"The name is: {a[0].Name}");
//         }
//     }

// deep copy example below:

// class ArrayFunc
//     {
//         public string Name;
//         public int age;
//     }

//     class ArrayExec
//     {
//       static void Main(string[] args)
//       {
//           ArrayFunc[] a =
//         {
//             new ArrayFunc { Name = "Asfand", age = 21},
//             new ArrayFunc { Name = "Aman", age = 21}
//         };

//         ArrayFunc[] b = new ArrayFunc[a.Length];
//         for (int i = 0; i < a.Length; i++)
//         {
//             b[i] = new ArrayFunc { Name = a[i].Name, age = a[i].age };
//         }

//         b[0].Name = "Raamis";
//         a[0].Name = "Umair";
//         b[0].age = 23;

//         Console.WriteLine($"The name is: {b[0].Name}");
//         Console.WriteLine($"The name is: {a[0].Name}");
//         Console.WriteLine($"The age is : {b[0].age}");
//         Console.WriteLine($"The age is : {a[0].age}");
//       }
//     }

//C# params array (params keyword):

class ParamsArray
    {
        static void Main(string[] args)
        {
            // ParamsArray p = new ParamsArray();
            // p.printcities("Karachi", "Lahore", "Islamabadiies", "Blackies");
            new ParamsArray().printcities("New York", "Los Angeles", "Chicago", "Houston"); //single-line call option to pass printing cities. 

        }

        void printcities (params string[] cities)
        {
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    // class GroceryPaarams
    // {
    //     static void Main(string[] args)
    //     {
    //         GroceryPaarams g = new GroceryPaarams();
    //         g.printGroceryItems("Apple", "Banana", "Orange", "Mango");
    //     }

    //     void printGroceryItems (params string[] items)
    //     {
    //         foreach (string item in items)
    //         {
    //             Console.WriteLine(item);
    //         }
    //     }
    // }


}