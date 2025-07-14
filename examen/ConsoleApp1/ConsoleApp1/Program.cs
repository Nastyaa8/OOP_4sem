using System;

namespace RectangleApp
{
    class Rectangle
    {

        public double Width { get; set; }
        public double Height { get; set; }


        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


        public double GetArea()
        {
            return Width * Height;
        }


        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите ширину прямоугольника");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту прямоугольника");
            double height = Convert.ToDouble(Console.ReadLine());
           
            Rectangle rect = new Rectangle(width, height);
            Console.WriteLine(rect.GetArea());
            Console.WriteLine(rect.GetPerimeter());
        }
    }
}