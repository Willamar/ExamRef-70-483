using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Chapter4._2_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = UpdateRows();

            t.Wait();

            Console.Read();
        }

        public static async Task UpdateRows()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EXAMREF70483"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE People SET FirstName = 'John'", con);
                await con.OpenAsync();

                int numberOfUpdatedRows = await cmd.ExecuteNonQueryAsync();
                Console.WriteLine("Updated {0} rows", numberOfUpdatedRows);
            }
        }

    }
}
