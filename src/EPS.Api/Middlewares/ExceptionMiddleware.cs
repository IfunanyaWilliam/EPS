﻿using EPS.Application.Common.DTO;
using System.Text.Json;

namespace EPS.Api.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next,
            ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            if (context.Response.HasStarted)
            {
                _logger.LogError("Response already started, skipping exception handling.");
                return;
            }

            _logger.LogError(ex, "An exception occurred while processing the request.");

            // Set status only if response hasn't started
            context.Response.Clear();
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            var errorResponse = ResponseBase<object>.Fail(
                message: "An internal server error occurred.",
                statusCode: StatusCodes.Status500InternalServerError);

            await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
        }
    }
}
