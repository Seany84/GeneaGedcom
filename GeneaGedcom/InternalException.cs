using System;

namespace GedcomCore.Framework
{
    class InternalException : Exception
    {
        public InternalException(string Message) 
            : base(Message)
        {
        }

        public InternalException(string Message, Exception InnerException)
            : base(Message, InnerException)
        {
        }
    }
}
