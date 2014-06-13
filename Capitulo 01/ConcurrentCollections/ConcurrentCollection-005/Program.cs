using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollection_005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack - Pilha (LIFO) 
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            //Adiciona um item na pilha
            stack.Push(42);

            int result;
     
            //metodo trypop retorna o ultimo item a ser adicionado na lista, caso não tenha mais item ele não dar por que ele "tenta(try)" pega um item
            //quando usar o metodo trypop o item é removido da coleção
            if (stack.TryPop(out result))
            {
                Console.WriteLine("Popped: {0}", result);
            }
            if (stack.TryPop(out result))
            {
                Console.WriteLine("Popped: {0}", result);
            }

            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            //metod retorna uma coleção de itens da pilha
            stack.TryPopRange(values);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
