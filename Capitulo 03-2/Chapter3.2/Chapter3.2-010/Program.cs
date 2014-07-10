using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_010
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAS de forma imperativa(imperative)
            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Read;

            try
            {
                f.Demand();

            }
            catch (SecurityException ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
