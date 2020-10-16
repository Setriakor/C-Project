using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class NobodyHomeException : Exception
    {
        public NobodyHomeException(String message):base(message)
        {
        }
    }
}
