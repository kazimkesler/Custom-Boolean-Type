using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Created : SuccessResult
    {
        internal Created(string message) : base(StatusCode.Created, message)
        {
        }
        internal Created() : base(StatusCode.Created, default)
        {
        }
    }
}
