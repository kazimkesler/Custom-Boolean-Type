using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Ok<T> : SuccessResult<T>
    {
        internal Ok(T data, string message) : base(ResultCodes.OK, data, message)
        {
        }
        internal Ok(T data) : base(ResultCodes.OK, data, default)
        {
        }
    }
}
