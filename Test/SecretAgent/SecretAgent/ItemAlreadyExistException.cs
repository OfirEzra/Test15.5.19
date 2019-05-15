using System;
using System.Runtime.Serialization;

namespace SecretAgent
{
    [Serializable]
    internal class ItemAlreadyExistException : Exception
    {
        public ItemAlreadyExistException()
        {
        }

        public ItemAlreadyExistException(string message) : base(message)
        {
        }

        public ItemAlreadyExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}