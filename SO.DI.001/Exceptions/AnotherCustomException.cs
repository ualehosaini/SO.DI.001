using System;
using System.Runtime.Serialization;

namespace SO.DI._001.Exceptions
{
    public class AnotherCustomerException : Exception
    {
        public AnotherCustomerException()
        {
        }

        public AnotherCustomerException(string message) : base(message)
        {
        }

        public AnotherCustomerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AnotherCustomerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
