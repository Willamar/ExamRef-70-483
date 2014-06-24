using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeTypes_008
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            OpenConnection(con);
        }

        static void OpenConnection(DbConnection connection)
        {
            //só vai retorna true se o tipo for compativel
            if (connection is SqlConnection)
            {
                // run some special code
            }
        }

        void LogStream(Stream stream)
        {
            MemoryStream memoryStream = stream as MemoryStream;
            if (memoryStream != null)
            {
                // .....
            }
        }

    }
}
