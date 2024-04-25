
namespace Academy.Service.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message) 
        {
            message = message.Trim();
        }
    }
}
