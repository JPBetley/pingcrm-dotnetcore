using System;

namespace InertiaAdapter.Exceptions
{
    public class KeyDoesNotExistException : Exception
    {
        public KeyDoesNotExistException()
        {
        }

        public KeyDoesNotExistException(string message)
            : base(message)
        {
        }

        public KeyDoesNotExistException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
