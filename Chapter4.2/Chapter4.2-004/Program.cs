using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Chapter4._2_004
{
    class Program
    {
        static void Main(string[] args)
        {

            Task t = SelectDataFromTable();

            t.Wait();

            Console.Read();
        }

        public static async Task SelectDataFromTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EXAMREF70483"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM People", con);
                await con.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    string formatStringWithMiddleName = "Person ({0}) is named {1} {2} {3}";
                    string formatStringWithoutMiddleName = "Person ({0}) is named {1} {3}";

                    if (dr["middlename"] == null)
                    {
                        Console.WriteLine(formatStringWithoutMiddleName,
                            dr["id"],
                            dr["firstname"],
                            dr["lastname"]);
                    }
                    else
                    {
                        Console.WriteLine(formatStringWithMiddleName,
                            dr["id"],
                            dr["firstname"],
                            dr["middlename"],
                            dr["lastname"]);
                    }
                }

                dr.Close();
            }
        }
    }
}
