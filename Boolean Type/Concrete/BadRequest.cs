using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class BadRequest : ErrorResult
    {
        internal BadRequest(string message) : base(ResultCodes.BadRequest, message)
        {
        }
        internal BadRequest() : base(ResultCodes.BadRequest, default)
        {
        }
    }
}
