using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollection_007
{
    class Program
    {
        static void Main(string[] args)
        {
            //Colletion Dictionary usa par de dados key e value
            // no exempplo a seguir usamos a key como string e o value como int
            ConcurrentDictionary<string, int> dict = new ConcurrentDictionary<string, int>();
            //tenta adicionar um item na coleção com a key k1 e o value 42
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }
            //metodo tenta atualizar o item que tiver com a chave k1 atualizando o seu valor para 21, passamos tb o valor antigo para comparação
            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }
            //atualiza o item que tiver a chave k1
            dict["k1"] = 42; //Overwrite unconditionally

            //metodo vai tentar atualizar um item, caso não exita ele vai adicionar um novo item na coleção com a chave k1 e com o valor 3
            //caso exista ele vai usar lambda para atualizar o item, s seria a chave e o i o valor
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);

            //metodo tenta pega um item, caso não exita ele adiciona um item e joga o valor que foi adicionado na variavel
            int r2 = dict.GetOrAdd("k2", 3);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadLine();
        }
    }
}
