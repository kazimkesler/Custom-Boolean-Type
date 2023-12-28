using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    internal sealed class Conflict : ErrorResult
    {
        internal Conflict(string message) : base(ResultCodes.Conflict, message)
        {
        }
        internal Conflict() : base(ResultCodes.Conflict, default)
        {
        }
    }
}
