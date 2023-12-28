using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Ok : SuccessResult
    {
        internal Ok(string message) : base(ResultCodes.OK, message)
        {
        }
        internal Ok() : base(ResultCodes.OK, default)
        {
        }
    }
}
