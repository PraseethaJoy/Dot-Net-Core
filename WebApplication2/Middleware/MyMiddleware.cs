using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Middleware
{
    public static class MyMiddleware
    {
        public static IApplicationBuilder UseMyMiddlewareExtension(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<TestMiddleware>();
        }
    }

    public class TestMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public TestMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _logger = logFactory.CreateLogger("MyMiddleware");
            _next = next;            
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("MyMiddleware executing..");


            await _next(httpContext);
        }
    }
}
