using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Exception_Handling_Assignment
{
    public class ZeroException : Exception
    {
        public override string Message
        {
            get
            {
                return "Really? Zero? No one believes those lies.............. ";
            }
        }
    }
}
