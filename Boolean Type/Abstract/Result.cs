using Core.Results.Concrete;
using System.Text.Json.Serialization;

namespace Core.Results.Abstract
{
    public abstract class Result
    {
        public bool Success { get; protected set; }
        [JsonIgnore]
        public StatusCode StatusCode { get; protected set; }
        public object Data { get; set; }
        public string Message { get; protected set; }

        protected Result(bool success, StatusCode statusCode, string message)
        {
            if (statusCode.IsSuccess() != success)
                throw new Exception("Wrong status code");
            Success = success;
            StatusCode = statusCode;
            Message = message;
        }


        public static implicit operator bool(Result result) => result.Success;
        public static bool operator true(Result result) => result;
        public static bool operator false(Result result) => !result;
        public static Result operator &(Result left, Result right) => right ? new Success() : right;
        public static Result operator |(Result left, Result right) => right ? right : new Error();

        public override string ToString()
        {
            return $"{Success}({StatusCode}): {Message}";
        }

        public static Result OK() => new OK();
        public static Result OK(string message) => new OK(message);
        public static Result OK<T>(T data) => new OK<T>(data);
        public static Result OK<T>(T data, string message) => new OK<T>(data, message);
        public static Result Created() => new Created();
        public static Result Created(string message) => new Created(message);
        public static Result Created<T>(T data) => new Created<T>(data);
        public static Result Created<T>(T data, string message) => new Created<T>(data, message);
        public static Result NoContent() => new NoContent();
        public static Result NoContent(string message) => new NoContent(message);
        public static Result BadRequest() => new BadRequest();
        public static Result BadRequest(string message) => new BadRequest(message);
        public static Result NotFound() => new NotFound();
        public static Result NotFound(string message) => new NotFound(message);
        public static Result Unauthorized() => new Unauthorized();
        public static Result Unauthorized(string message) => new Unauthorized(message);
        internal static Result InternalServerError() => new InternalServerError();
        internal static Result InternalServerError(string message) => new InternalServerError(message);
    }
}
