using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_011
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectagle rectangle = new Square();

            rectangle.Width = 10;
            rectangle.Height = 5;

            Console.WriteLine(rectangle.Area);

            Console.Read();

        }
    }


    class Rectagle
    {

        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public Rectagle() { }
        public Rectagle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }
    }

    class Square : Rectagle
    {
        public Square(){}
        public Square(int width, int height)
            : base(width,height)
        {
        }
        public override int Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

    }
}
