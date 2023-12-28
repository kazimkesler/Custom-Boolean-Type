using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Forbidden : ErrorResult
    {
        internal Forbidden(string message) : base(ResultCodes.Forbidden, message)
        {

        }
        internal Forbidden() : base(ResultCodes.Forbidden, default)
        {

        }
    }
}
