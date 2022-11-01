using System.Diagnostics;

namespace MiddlewareExample.Middlewares
{
    public class PerformanceCounterMiddleware
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();
        private readonly RequestDelegate _next;

        public PerformanceCounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public Task Invoke(HttpContext httpContext)
        {
            Stopwatch.Start();
            var result = _next(httpContext);
            var HttpMethod = httpContext.Request.Method;
            var path = httpContext.Request.Path;
            var totalTime = Stopwatch.Elapsed.TotalMilliseconds;
            Stopwatch.Stop(); 
            Stopwatch.Reset(); 
            return result;
        }
    } 
    
}
