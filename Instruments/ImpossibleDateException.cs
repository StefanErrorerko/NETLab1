using System;

namespace NET_Lab1.Instruments
{
    class ImpossibleDateException : Exception
    {
        public ImpossibleDateException(string message) : base(message) { }
    }
}
