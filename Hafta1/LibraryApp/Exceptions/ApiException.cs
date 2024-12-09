using LibraryApp.Enums;

namespace LibraryApp.Exceptions
{
    public class ApiException : Exception
    {
        public ErrorCodes ErrorCode { get; set; }

        public ApiException(string message, ErrorCodes errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
