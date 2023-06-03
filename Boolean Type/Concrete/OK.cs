using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class OK : SuccessResult
    {
        internal OK(string message) : base(StatusCode.OK, message)
        {
        }
        internal OK() : base(StatusCode.OK, default)
        {
        }
    }
}
