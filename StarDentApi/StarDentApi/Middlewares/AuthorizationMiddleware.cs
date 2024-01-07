using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using StarDentApi.Repositories;
using System.Net;

namespace StarDentApi.Middlewares
{

    public static class AuthorizationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthorizationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorizationMiddleware>();
        }
    }

    public class AuthorizationMiddleware
    {

        private readonly RequestDelegate _next;
        public AuthorizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ApplicationDbContext dbContext)
        {
            //var authorizeAttributes = context.GetEndpoint()?.Metadata?.GetOrderedMetadata<IAuthorizeData>();

            //foreach (var attr in authorizeAttributes)
            //{
            //    Console.WriteLine(attr);
            //}

            if (context.GetEndpoint()?.Metadata?.GetMetadata<IAllowAnonymous>() == null &&
              !context.User.Identity?.IsAuthenticated == true)
            {




                // Eğer kullanıcı kimliği doğrulanmadıysa ve yetkilendirme gerekiyorsa
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("Unauthorized");
                return;
            }

            

            await _next(context);
        }
    }
}
