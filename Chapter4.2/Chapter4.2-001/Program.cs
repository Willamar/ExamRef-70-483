using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Chapter4._2_001
{
    class Program
    {
        static string connectionString = "Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;server=(local)";
      
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //Execute oprations against the database
            } // con is automatically closed.

            //não precisa fechar a conexão, o using chama o metodo dispose da DbConnection
        }
    }
}
