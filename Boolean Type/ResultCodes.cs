namespace Core.Results
{
    public static class StatusCodeExtension
    {
        public static bool IsSuccess(this ResultCodes statusCode) => (int)statusCode / 100 == 2 || (int)statusCode == 1;
    }
    public enum ResultCodes
    {
        True = 1,
        False = 0,

        Continue = 100,
        SwitchingProtocols = 101,
        Processing = 102,
        OK = 200,
        Created = 201,
        Accepted = 202,
        NonAuthoritative = 203,
        NoContent = 204,
        ResetContent = 205,
        PartialContent = 206,
        MultiStatus = 207,
        AlreadyReported = 208,
        IMUsed = 226,
        MultipleChoices = 300,
        MovedPermanently = 301,
        Found = 302,
        SeeOther = 303,
        NotModified = 304,
        UseProxy = 305,
        SwitchProxy = 306,  // RFC 2616, removed
        TemporaryRedirect = 307,
        PermanentRedirect = 308,
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        NotAcceptable = 406,
        ProxyAuthenticationRequired = 407,
        RequestTimeout = 408,
        Conflict = 409,
        Gone = 410,
        LengthRequired = 411,
        PreconditionFailed = 412,
        RequestEntityTooLarge = 413,  // RFC 2616, renamed
        PayloadTooLarge = 413,  // RFC 7231
        RequestUriTooLong = 414,  // RFC 2616, renamed
        UriTooLong = 414,  // RFC 7231
        UnsupportedMediaType = 415,
        RequestedRangeNotSatisfiable = 416,  // RFC 2616, renamed
        RangeNotSatisfiable = 416,  // RFC 7233
        ExpectationFailed = 417,
        ImATeapot = 418,
        AuthenticationTimeout = 419,  // Not defined in any RFC
        MisdirectedRequest = 421,
        UnprocessableEntity = 422,
        Locked = 423,
        FailedDependency = 424,
        UpgradeRequired = 426,
        PreconditionRequired = 428,
        TooManyRequests = 429,
        RequestHeaderFieldsTooLarge = 431,
        UnavailableForLegalReasons = 451,
        InternalServerError = 500,
        NotImplemented = 501,
        BadGateway = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504,
        HttpVersionNotsupported = 505,
        VariantAlsoNegotiates = 506,
        InsufficientStorage = 507,
        LoopDetected = 508,
        NotExtended = 510,
        NetworkAuthenticationRequired = 511
    }
}
