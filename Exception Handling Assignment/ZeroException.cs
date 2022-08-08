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
                return "Not sure how you screwed this up.... Gratz on finding a way....!";
            }
        }
    }
}
