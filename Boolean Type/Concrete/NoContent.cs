using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class NoContent : SuccessResult
    {
        internal NoContent(string message) : base(StatusCode.NoContent, message)
        {
        }
        internal NoContent() : base(StatusCode.NoContent, default)
        {
        }
    }
}
