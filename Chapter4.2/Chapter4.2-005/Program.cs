using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Chapter4._2_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = SelectMultipleResultSets();

            t.Wait();

            Console.Read();
        }

        public static async Task SelectMultipleResultSets()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EXAMREF70483"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM People; SELECT TOP 1 * FROM People ORDER BY LastName", con);

                await con.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();

                await ReadQueryResults(dr);
                await dr.NextResultAsync();
                await ReadQueryResults(dr);

                dr.Close();
            }
        }

        private static async Task ReadQueryResults(SqlDataReader dr)
        {
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
        }
    }
}
