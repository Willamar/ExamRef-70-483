using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Chapter3._1_011
{
    class Program
    {
        static void Main(string[] args)
        {
            //adicionar a referencia ao System.Web.Extensions;
            //depois importa a namespace System.Wrb.Script.Serialization
            string json = "{\"nome\": \"Willamar\"}";


            var serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<Dictionary<string, object>>(json);

            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.Read();
        }
    }
}
