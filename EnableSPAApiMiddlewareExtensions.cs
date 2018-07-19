using System;
using Microsoft.AspNetCore.Builder;

namespace SpaApiMiddleware
{
    public static class EnableSPAApiMiddlewareExtensions
    {
         public static IApplicationBuilder UseSpaApiOnly(
            this IApplicationBuilder builder, string apiPath="api", string indexHtmlPage="index.html")
        {
            return builder.UseMiddleware<EnableSPAApiMiddleware>(apiPath, indexHtmlPage);
        }
    }
}
