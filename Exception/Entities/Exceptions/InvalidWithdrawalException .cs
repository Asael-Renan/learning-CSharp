namespace Exeption.Entities.Exceptions
{
    class InvalidWithdrawalException : ApplicationException
    {
        public InvalidWithdrawalException(string message) : base(message) { }
    }
}