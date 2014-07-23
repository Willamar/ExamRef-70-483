using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Chapter4._2_007
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = InsertRowWithParameterizedQuery();

            t.Wait();
            Console.Read();
        }

        public static async Task InsertRowWithParameterizedQuery()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EXAMREF70483"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleName]) VALUES(@firstName, @lastName, @middleName)", con);

                await con.OpenAsync();

                cmd.Parameters.AddWithValue("@firstName", "John");
                cmd.Parameters.AddWithValue("@lastName", "Doe");
                cmd.Parameters.AddWithValue("@middleName", "Little");

                int numberOfInsertedRows = await cmd.ExecuteNonQueryAsync();


                Console.WriteLine("Inserted {0} rows", numberOfInsertedRows);
            }
        }
    }
}
