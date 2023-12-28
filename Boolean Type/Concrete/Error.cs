using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Error : ErrorResult
    {
        internal Error() : base(ResultCodes.False, default)
        {
        }
    }
}
