using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;

namespace EPS.Application.Common.DTO
{
    public class ResponseBase<T>
    {
        public T? Data { get; set; }
        public string? Message { get; set; }

        [JsonPropertyName("isSuccess")]
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public ResponseBase<T> AddError(string error)
        {
            Errors?.Add(error);
            return this;
        }

        public ResponseBase<T> AddError(List<string> error)
        {
            Errors?.AddRange(error);
            return this;
        }

        public static ResponseBase<T> Success(string message, T data = default(T), int statusCode = StatusCodes.Status200OK)
        {
            return new ResponseBase<T>
            {
                Data = data,
                Message = message,
                StatusCode = statusCode,
                IsSuccess = true
            };
        }

        public static ResponseBase<T> Success(string message, int statusCode = StatusCodes.Status200OK)
        {
            return new ResponseBase<T>
            {
                Message = message,
                StatusCode = statusCode,
                IsSuccess = true
            };
        }

        public static ResponseBase<T> Fail(string message, int statusCode = StatusCodes.Status400BadRequest)
        {
            return new ResponseBase<T>
            {
                Message = message,
                StatusCode = statusCode,
                IsSuccess = false
            };
        }

        public static ResponseBase<T> Fail(string message, int statusCode, List<string> errors = null)
        {
            return new ResponseBase<T>
            {
                IsSuccess = false,
                Message = message,
                StatusCode = statusCode,
                Errors = errors ?? new List<string> { message }
            };
        }
    }
}
