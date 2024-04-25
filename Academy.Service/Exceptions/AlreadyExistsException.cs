
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
