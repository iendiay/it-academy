using System;

namespace Lesson15ExceptionDLL
{
    public class ValueException : Exception
    {
        public ValueException(string message) : base(message)
        {

        }

    }
}
