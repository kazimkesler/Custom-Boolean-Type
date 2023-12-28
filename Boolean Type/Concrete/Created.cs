using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Created : SuccessResult
    {
        internal Created(string message) : base(ResultCodes.Created, message)
        {
        }
        internal Created() : base(ResultCodes.Created, default)
        {
        }
    }
}
