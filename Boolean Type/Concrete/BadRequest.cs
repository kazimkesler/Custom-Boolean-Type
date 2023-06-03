using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class BadRequest : ErrorResult
    {
        internal BadRequest(string message) : base(StatusCode.BadRequest, message)
        {
        }
        internal BadRequest() : base(StatusCode.BadRequest, default)
        {
        }
    }
}
