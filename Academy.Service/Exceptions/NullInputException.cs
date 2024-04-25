
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
