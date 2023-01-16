using WebApplication1.Service.Interface;

namespace WebApplication1.Middleware
{
    public class ReaderMiddleware
    {
        IReader reader;

        public ReaderMiddleware(RequestDelegate _, IReader reader)
        {
            this.reader = reader;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync($"Current Value: {reader.ReadValue()}");
        }
    }
}
