using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swap numbers using third variable
            int x = 5;
            int y = 10;
            Console.WriteLine("x is " + x + " and y is " + y);
            int z = x;
            x = y;
            y = z;
            Console.WriteLine("After swapping x is " + x + " and y is " + y);

            //Swap numbers without using third variable
            int a = 10;
            int b = 15;
            Console.WriteLine("a is " + a + " and b is " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping a is " + a + " and b is " + b);



        }

    }
}