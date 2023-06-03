using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Created<T> : SuccessResult<T>
    {
        internal Created(T data, string message) : base(StatusCode.Created, data, message)
        {
        }
        internal Created(T data) : base(StatusCode.Created, data, default)
        {
        }
    }
}
