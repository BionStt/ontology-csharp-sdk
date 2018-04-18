using System;

namespace Basic.Exceptions
{
    public class InvalidPrivateKeyException : Exception
    {
        public InvalidPrivateKeyException()
        {
        }

        public InvalidPrivateKeyException(string privatekey)
            : base(String.Format("Invalid private key: {0}", privatekey))
        {
        }

        public InvalidPrivateKeyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
