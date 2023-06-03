namespace Core.Results.Abstract
{
    internal abstract class Result<T> : Result
    {
        public new T Data { get; set; }
        protected Result(bool success, StatusCode statusCode, string message, T data) : base(success, statusCode, message)
        {
            Data = data;
        }
    }
}
