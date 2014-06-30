using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_004
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();

            animal.Move();
            //Como a varivel é da interface, não tem como chamar o metodo Bark apesar dele referenciar a classe Dog
            //animal.Bark();
            //Só posso usar o metodo Bark se fizer um cast
            ((Dog)animal).Bark();
            //Tb posso usar a interface como parametro
            NomeAnimimal(animal);
        }

        private static void NomeAnimimal(IAnimal animal)
        {
            animal.Move();
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Dog : IAnimal
    {
        public void Move() { }
        public void Bark() { }
    }


}
