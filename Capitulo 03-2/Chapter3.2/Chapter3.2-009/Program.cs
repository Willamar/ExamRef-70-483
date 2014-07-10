using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_009
{
    class Program
    {
        //CAS de forma Declaritiva(Declarative)
        [FileIOPermission(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Read)]
        public void DeclarativeCAS()
        {
            //method body
        }

        static void Main(string[] args)
        {
        }
    }
}
