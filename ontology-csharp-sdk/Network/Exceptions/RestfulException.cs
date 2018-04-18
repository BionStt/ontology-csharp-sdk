using System;

namespace Network.Exceptions
{
    class RestfullException : Exception
    {
        public RestfullException()
        {
        }

        public RestfullException(string message)
            : base(message)
        {
        }

        public RestfullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
