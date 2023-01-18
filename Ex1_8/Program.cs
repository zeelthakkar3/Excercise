using System;

namespace MyApplication
{
    class Rectangle
    {
        public int l, b;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public void rectangleArea()
        {
            Console.WriteLine("Area of a rectangle : " + (l * b));
        }

        public void rectanglePerimeter()
        {
            Console.WriteLine("Perimeter of a rectangle : " + 2 * (l + b));
            
        }

        
    }

    class Square : Rectangle
    {
        int s;
        public Square(int l, int b) : base(l, b)
        {
            this.s = l;
            squareArea();
            squarePerimeter();

        }

        public void squareArea()
        {
            Console.WriteLine("Area of a Square : " + Math.Pow(s, 2));
        }

        public void squarePerimeter()
        {
            Console.WriteLine("Perimeter of a Square : " + 2 * s);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new(4, 6);
            sq.rectangleArea();
            sq.rectanglePerimeter();
        }
    }

}