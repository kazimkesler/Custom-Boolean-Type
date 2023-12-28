using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class NoContent : SuccessResult
    {
        internal NoContent(string message) : base(ResultCodes.NoContent, message)
        {
        }
        internal NoContent() : base(ResultCodes.NoContent, default)
        {
        }
    }
}
