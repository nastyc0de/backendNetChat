using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace API.Middleware
{
    public class ErrorHandling
    {
        private RequestDelegate _next { get; }
        private readonly ILogger<ErrorHandling> _logger;
        public ErrorHandling(RequestDelegate next, ILogger<ErrorHandling> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invole(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                
                await HandleExceptionAsync(context, ex, _logger);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex, ILogger<ErrorHandling> logger)
        {
            throw new NotImplementedException();
        }
    }
}