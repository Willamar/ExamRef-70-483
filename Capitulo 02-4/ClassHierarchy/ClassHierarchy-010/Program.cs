using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_010
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Rectagle
    {

        public int Width { get; set; }
        public int Height { get; set; }

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
}
