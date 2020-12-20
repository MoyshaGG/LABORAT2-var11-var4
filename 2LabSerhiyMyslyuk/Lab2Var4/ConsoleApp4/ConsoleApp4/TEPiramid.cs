using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class TEPiramid : TETriangle
    {
        private double height;
        static Random rnd = new Random();

        public void Scope()
        {
            double scope = (height * Math.Pow(Side, 2)) / (4 * Math.Sqrt(3));
            Console.WriteLine();
            Console.WriteLine("Об'єм пiрамiди: " + scope);
            Console.WriteLine("Висота пiрамiди: " + height);
            
        }
            
            
        public double Height

        {
            get { return height; }
            set { if (value > 0) height = value; }
        }

        public TEPiramid()
        {
            side = rnd.Next(1, 100);
            height = rnd.Next(1, 100);
        }
        public TEPiramid(double side, double height)
        {
            this.side = side;
            this.height = height;
        }

        public TEPiramid(TEPiramid TEPiramid)
        {
            this.side = TEPiramid.side;
            this.height = TEPiramid.height;

        }
    }
}
