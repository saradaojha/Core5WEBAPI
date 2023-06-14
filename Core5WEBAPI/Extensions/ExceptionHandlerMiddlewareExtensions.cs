using Core5WEBAPI.CustomExceptionMiddleware;
using Microsoft.AspNetCore.Builder;

namespace Core5WEBAPI.Extensions
{
    public static class ExceptionHandlerMiddlewareExtensions
    {
        public static void UseExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
