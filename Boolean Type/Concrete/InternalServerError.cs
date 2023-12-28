using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal class InternalServerError : ErrorResult
    {
        internal InternalServerError(string message) : base(ResultCodes.InternalServerError, message)
        {
        }
        internal InternalServerError() : base(ResultCodes.InternalServerError, default)
        {
        }
    }
}
