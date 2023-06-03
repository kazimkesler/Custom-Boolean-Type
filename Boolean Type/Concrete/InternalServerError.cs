using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal class InternalServerError : ErrorResult
    {
        internal InternalServerError(string message) : base(StatusCode.InternalServerError, message)
        {
        }
        internal InternalServerError() : base(StatusCode.InternalServerError, default)
        {
        }
    }
}
