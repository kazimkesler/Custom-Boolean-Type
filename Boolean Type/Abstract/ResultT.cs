namespace Core.Results.Abstract
{
    public abstract class Result<T> : Result
    {
        public new T Data { get; set; }
        protected Result(bool success, ResultCodes statusCode, string message, T data) : base(success, statusCode, message)
        {
            Data = data;
        }
    }
}
