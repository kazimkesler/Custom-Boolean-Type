﻿namespace Core.Results.Abstract
{
    internal abstract class SuccessResult<T> : Result<T>
    {
        protected SuccessResult(ResultCodes statusCode, T data, string message) : base(true, statusCode, message, data)
        {
        }
    }
}
