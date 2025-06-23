namespace LambdaRegionComunaNet8.Middleware
{
    public class TokenAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenAuthMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            var token = Environment.GetEnvironmentVariable("API_KEY") ?? "supersecreto123";

            if (!context.Request.Headers.TryGetValue("X-Api-Key", out var headerToken) || headerToken != token)
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized: Invalid Token");
                return;
            }

            await _next(context);
        }
    }
}
