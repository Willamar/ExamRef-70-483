using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Chapter4._2_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnectionsStringBuilder = new SqlConnectionStringBuilder();

            sqlConnectionsStringBuilder.DataSource = @"(localdb)\v11.0";
            sqlConnectionsStringBuilder.InitialCatalog = "ProgrammingInCSharp";

            string connectionString = sqlConnectionsStringBuilder.ToString();
        }
    }
}
