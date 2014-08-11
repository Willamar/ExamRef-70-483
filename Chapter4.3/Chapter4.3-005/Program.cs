using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._3_005
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [Serializable]
    public class PersonComplex : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private bool isDirty = false;

        public PersonComplex() { }

        protected PersonComplex(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("value1");
            Name = info.GetString("value2");
            isDirty = info.GetBoolean("value3");
        }
        
        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("value1", Id);
            info.AddValue("value2", Name);
            info.AddValue("value3", isDirty);
        }
    }
}
