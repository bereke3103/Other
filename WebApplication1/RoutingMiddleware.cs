namespace WebApplication1
{
    public class RoutingMiddleware
    {
        readonly RequestDelegate next;
        public RoutingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path == "/index")
            {
                await context.Response.WriteAsync("INDEX PAGE");
            }
            else if (context.Request.Path == "/about")
            {
                await context.Response.WriteAsync("ABOUT PAGE");
            }
            else
            {
                context.Response.StatusCode= 404;
            }
        }
    }
}
