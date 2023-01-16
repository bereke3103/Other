using WebApplication1.Service;

namespace WebApplication1.Middleware
{
    public class TimeMessageMiddleware
    {
        private readonly RequestDelegate next;

        public TimeMessageMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, ITimeService service)
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.WriteAsync($"<h1>Time: {service.GetTtime()}</h1>");
        }
    }
}
