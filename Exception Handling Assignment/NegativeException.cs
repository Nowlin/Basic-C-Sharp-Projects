using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Exception_Handling_Assignment
{
    public class NegativeException : Exception
    {
        public NegativeException(string message) : base(message)
        {
        }
    }
}
