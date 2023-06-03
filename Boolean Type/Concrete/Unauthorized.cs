using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Unauthorized : ErrorResult
    {
        internal Unauthorized(string message) : base(StatusCode.Unauthorized, message)
        {

        }
        internal Unauthorized() : base(StatusCode.Unauthorized, default)
        {

        }
    }
}
