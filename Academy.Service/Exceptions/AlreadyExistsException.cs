using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Service.Exceptions
{
    internal class AlreadyExistsException : Exception
    {
        public AlreadyExistsException(string message) : base(message)
        {
            message = message.Trim();
        }
    }
}
