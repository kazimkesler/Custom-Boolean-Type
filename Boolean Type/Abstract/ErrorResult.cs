namespace Core.Results.Abstract
{
    internal abstract class ErrorResult : Result
    {
        protected ErrorResult(ResultCodes statusCode, string message) : base(false, statusCode, message)
        {
        }
    }
}
