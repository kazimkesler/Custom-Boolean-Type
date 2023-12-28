using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Success : SuccessResult
    {
        internal Success() : base(ResultCodes.True, default)
        {
        }
    }
}
