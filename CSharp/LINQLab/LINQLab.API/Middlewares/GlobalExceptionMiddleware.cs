using LinqLab.Domain.Exceptions;
using LINQLab.API.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace LINQLab.API.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
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

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            var errorResponse = new ErrorResponse();

            switch (exception)
            {
                case ValidationException validationEx:
                    response.StatusCode = StatusCodes.Status400BadRequest;
                    errorResponse.Message = "Validation failed";



                    //errorResponse.Errors = validationEx.Errors
                    //    .GroupBy(e => e.PropertyName)
                    //    .ToDictionary(
                    //        g => g.Key,
                    //        g => g.Select(e => e.ErrorMessage).ToArray()
                    //    );
                    break;

                case BusinessRuleViolationException businessEx:
                    response.StatusCode = StatusCodes.Status400BadRequest;
                    errorResponse.Message = businessEx.Message;
                    break;

                case NotFoundException notFoundEx:
                    response.StatusCode = StatusCodes.Status404NotFound;
                    errorResponse.Message = notFoundEx.Message;
                    break;

                default:
                    response.StatusCode = StatusCodes.Status500InternalServerError;
                    errorResponse.Message = "An unexpected error occurred";
                    _logger.LogError(exception, "Unhandled exception");
                    break;
            }

            var jsonResponse = JsonSerializer.Serialize(errorResponse);
            await response.WriteAsync(jsonResponse);
        }
    }
}
