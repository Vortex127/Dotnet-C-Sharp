using System;

namespace CorePractice
{
    class Practice
    {
        static void Main(string[] args)
        {
            string[] cars;
            cars = new string[] { "hdjhd", "djdh" }; // correct way of declaring first, initializing later. If I don't add new here, it'll give an error.
            Console.WriteLine("helo: " + string.Join(", ", cars));
        }
    }
}




// int[] arr1 = [1, 2, 3, 4, 5];
//             int n = arr1.Length;
//             int[] temp = new int[n];

//             for (int i = 0; i < n; i++)
//             {
//                 temp[i] = arr1[n - i - 1];
//             }

//             for (int i = 0; i < n; i++)
//             {
//                 arr1[i] = temp[i];
//                  Console.Write(temp[i] + " ");
//             }
// Console.WriteLine("The reversed array is: " + String.Join(", ", temp));