using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Created<T> : SuccessResult<T>
    {
        internal Created(T data, string message) : base(ResultCodes.Created, data, message)
        {
        }
        internal Created(T data) : base(ResultCodes.Created, data, default)
        {
        }
    }
}
