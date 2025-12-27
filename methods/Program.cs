using System;
using System.IO.Pipelines;

namespace Methods_Apps
{
    class Methods
    {
        //this below example is for pass by value

        void changeNumber(int num)
        {
            num = 10;
        }

        static void Main(string[] args)
        {
            int x = 5;
            Methods m = new Methods();
            m.changeNumber(x);
            Console.WriteLine(x);
        }

        // this below example is for pass by reference

        // void changeNumber(ref int num)
        // {
        //     num = 10;
        // }
        // static void Main(string[] args)
        // {
        //     int x = 5; // x references to the num variable in the method because int num was an alias of x and was the original memory location.
        //     Methods m = new Methods();
        //     m.changeNumber(ref x);
        //     Console.WriteLine(x);
        // }

        // void changeNumbers(out int num1, out int num2)
        // {
        //     num1 = 10;
        //     num2 = 20;
        // }
        // static void Main(string[] args)
        // {
        //     int num1, num2;
        //     Methods m = new Methods();
        //     m.changeNumbers(out num1, out num2);
        //     Console.WriteLine(num1);
        //     Console.WriteLine(num2);
        // }

    //     int checking (in int a, in int b)
    //     {
    //         return a*b;
    //     }

    //     static void Main(string[] args)
    //     {
    //         Methods m = new Methods();
    //         int a = 10;
    //         int b = 10;
    //         int res = m.checking(in a, in b);
    //         Console.WriteLine(res);
    //     }
    }
}