namespace Core.Results.Abstract
{
    internal abstract class ErrorResult : Result
    {
        protected ErrorResult(StatusCode statusCode, string message) : base(false, statusCode, message)
        {
        }
    }
}
