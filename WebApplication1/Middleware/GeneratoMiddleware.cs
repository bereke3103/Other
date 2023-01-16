using WebApplication1.Service.Interface;

namespace WebApplication1.Middleware
{
    public class GeneratoMiddleware
    {
        RequestDelegate next;
        IGenerator generator;

        public GeneratoMiddleware(RequestDelegate next, IGenerator generator)
        {
            this.next = next;
            this.generator = generator;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path == "/generate")
            {
                await context.Response.WriteAsync($"New Value: {generator.GeneratorValue()}");
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}
