using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class NotFound : ErrorResult
    {
        internal NotFound(string message) : base(StatusCode.NotFound, message)
        {

        }
        internal NotFound() : base(StatusCode.NotFound, default)
        {

        }
    }
}
