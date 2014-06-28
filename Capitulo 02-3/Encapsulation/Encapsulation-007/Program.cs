using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_007
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface ILeft
    {
        void Move();
    }

    interface IRight
    {
        void Move();
    }

    class MoveableObject : ILeft, IRight
    {
        void ILeft.Move(){ }
        void IRight.Move(){ }
    }
}
