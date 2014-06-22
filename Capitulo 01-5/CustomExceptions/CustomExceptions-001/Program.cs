using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CustomExceptions_001
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [Serializable]
    public class OrderProcessingException : Exception, ISerializable
    {
        public int OrderId { get; set; }

        public OrderProcessingException(int orderId)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/inforaboutexception";
        }

        public OrderProcessingException(int orderId, string message, Exception innerException)
            : base(message, innerException)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/inforaboutexception";
        }

        public OrderProcessingException(SerializationInfo info, StreamingContext context)
        {
            OrderId = (int)info.GetValue("orderId", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("OrderId", OrderId, typeof(int));
        }
    }
}
