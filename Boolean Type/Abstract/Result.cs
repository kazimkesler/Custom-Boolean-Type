using Core.Results.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace Core.Results.Abstract
{
    public abstract class Result
    {
        public bool Success { get; protected set; }
        [JsonIgnore]
        public ResultCodes StatusCode { get; protected set; }
        public object Data { get; set; }
        public string Message { get; protected set; }

        protected Result(bool success, ResultCodes statusCode, string message)
        {
            if (statusCode.IsSuccess() != success)
                throw new InvalidOperationException("Wrong status code");
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

        public IActionResult ObjectResult()
        {
            return new ObjectResult(StatusCode == ResultCodes.NoContent ? null : this)
            {
                StatusCode = (int)StatusCode
            };
        }

        public static Result Ok() => new Ok();
        public static Result OkWithMessage(string message) => new Ok(message);
        public static Result Ok<T>(T data) => new Ok<T>(data);
        public static Result OkWithMessage<T>(T data, string message) => new Ok<T>(data, message);
        public static Result Created() => new Created();
        public static Result CreatedWithMessage(string message) => new Created(message);
        public static Result Created<T>(T data) => new Created<T>(data);
        public static Result CreatedWithMessage<T>(T data, string message) => new Created<T>(data, message);
        public static Result NoContent() => new NoContent();
        public static Result NoContentWithMessage(string message) => new NoContent(message);

        public static Result Conflict() => new Conflict();
        public static Result Conflict(string message) => new Conflict(message);
        public static Result BadRequest() => new BadRequest();
        public static Result BadRequest(string message) => new BadRequest(message);
        public static Result NotFound() => new NotFound();
        public static Result NotFound(string message) => new NotFound(message);
        public static Result Unauthorized() => new Unauthorized();
        public static Result Unauthorized(string message) => new Unauthorized(message);
        public static Result Forbidden() => new Forbidden();
        public static Result Forbidden(string message) => new Forbidden(message);
        internal static Result InternalServerError() => new InternalServerError();
        internal static Result InternalServerError(string message) => new InternalServerError(message);
    }
}
