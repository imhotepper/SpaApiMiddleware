using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace SpaApiMiddleware
{
    public class EnableSPAApiMiddleware
    {
        private readonly RequestDelegate _next;
        private string _apiPath;
        private string _indexHtmlPage;

        public EnableSPAApiMiddleware(RequestDelegate next, string apiPath, string indexHtmlPage)
        {
            _apiPath = apiPath;
            _indexHtmlPage = indexHtmlPage;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context); 
            var path = context.Request.Path.Value;

            if (!path.StartsWith($"/{_apiPath}") && !Path.HasExtension(path)) 
            { 
                context.Request.Path = $"/{_indexHtmlPage}"; 
                await _next(context); 
            } 
        }
    }
}
