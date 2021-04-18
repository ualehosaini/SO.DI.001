using System;
using System.Runtime.Serialization;

namespace SO.DI._001.Exceptions
{
    public class SomeCustomException : Exception
    {
        public SomeCustomException()
        {
        }

        public SomeCustomException(string message) : base(message)
        {
        }

        public SomeCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SomeCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
