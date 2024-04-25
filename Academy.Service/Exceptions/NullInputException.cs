using Academy.Service.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Service.Exceptions
{
    public class NullInputException : Exception
    {
        public NullInputException(string message) : base(message)
        {
            message = message.Trim();
        }
    }
}
