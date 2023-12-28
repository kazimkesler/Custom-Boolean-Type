using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Unauthorized : ErrorResult
    {
        internal Unauthorized(string message) : base(ResultCodes.Unauthorized, message)
        {

        }
        internal Unauthorized() : base(ResultCodes.Unauthorized, default)
        {

        }
    }
}
