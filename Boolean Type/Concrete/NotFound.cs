using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class NotFound : ErrorResult
    {
        internal NotFound(string message) : base(ResultCodes.NotFound, message)
        {

        }
        internal NotFound() : base(ResultCodes.NotFound, default)
        {

        }
    }
}
