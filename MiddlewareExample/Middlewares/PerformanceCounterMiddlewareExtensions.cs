namespace MiddlewareExample.Middlewares
{
    public static class PerformanceCounterMiddlewareExtensions
    {
        public static IApplicationBuilder UsePerformanceCounterMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PerformanceCounterMiddleware>();
        }
    }
}
