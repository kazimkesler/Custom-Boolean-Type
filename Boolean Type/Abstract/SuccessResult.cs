namespace Core.Results.Abstract
{
    internal abstract class SuccessResult : Result
    {
        protected SuccessResult(StatusCode statusCode, string message) : base(true, statusCode, message)
        {
        }
    }
}
