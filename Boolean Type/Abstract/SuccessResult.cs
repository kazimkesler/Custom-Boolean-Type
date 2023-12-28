namespace Core.Results.Abstract
{
    internal abstract class SuccessResult : Result
    {
        protected SuccessResult(ResultCodes statusCode, string message) : base(true, statusCode, message)
        {
        }
    }
}
