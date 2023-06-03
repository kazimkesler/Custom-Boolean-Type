using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class OK<T> : SuccessResult<T>
    {
        internal OK(T data, string message) : base(StatusCode.OK, data, message)
        {
        }
        internal OK(T data) : base(StatusCode.OK, data, default)
        {
        }
    }
}
