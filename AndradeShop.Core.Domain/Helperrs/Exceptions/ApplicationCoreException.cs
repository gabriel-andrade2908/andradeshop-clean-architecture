namespace AndradeShop.Core.Domain.Helperrs.Exceptions
{
    public class ApplicationCoreException : Exception
    {
        public ApplicationCoreException(string? message) : base(message)
        {
        }

        public ApplicationCoreException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
