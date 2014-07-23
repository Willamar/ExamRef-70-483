using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Chapter4._2_008
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EXAMREF70483"].ConnectionString;

            using (TransactionScope transactionScope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("INSERT INTO People ([FirstName], [LastName], [MiddleInitial]) VALUES('John', 'Doe', null)", con);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO People ([FirstName], [LastName], [MiddleInitial]) VALUES('Jane', 'Doe', null)", con);


                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }

                transactionScope.Complete();
            }
        }
    }
}
