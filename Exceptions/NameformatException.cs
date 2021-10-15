using System;

namespace Exceptions
{
    class NameformatException : AppException
    {
        public NameformatException(string msg) : base(msg)
        {

        }
    }
}
