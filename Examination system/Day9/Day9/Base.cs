using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
  abstract class Shape
    {
        float dim1;
        float dim2;


        public float Dim1 { get { return dim1; } set { dim1 = value; } }
        public float Dim2 { get { return dim2; } set { dim2 = value; } }

        public Shape(int d1, int d2)
        {
            dim1 = d1;

            dim2 = d2;
        }
        public Shape()
        {

        }
        public void Show()
        {
            Console.WriteLine("Shape");

        }

        public abstract float Area();
       
    }
    class Rect : Shape
    {
        public Rect()
        {
            
        }
        public Rect(int w, int h) : base(w, h)
        {

        }
        public override float Area()
        {
            Console.WriteLine("Rect");
            return Dim1*Dim2;
        }
        public override string ToString()
        {
            return $"Width :{Dim1},  Hight :{Dim2}";
        }


    }
    class squar : Rect
    {


    }

    class Circle : Shape
    {
        public Circle(int r) : base(r, r)
        {

        }
        public override float Area()
        {
            Console.WriteLine("Circle");
            return Dim1 * Dim2 * 22 / 7;


        }

    }
    class Triangle : Shape
    {
        public Triangle(int b, int h) : base(b, h)
        {

        }
        public override float Area()
        {
            Console.WriteLine("Triangle");
            
            return Dim1 * Dim2 / 2;
        }

    }
}
