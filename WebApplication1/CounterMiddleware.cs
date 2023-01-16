using WebApplication1.Service;

namespace WebApplication1
{
    public class CounterMiddleware
    {
        RequestDelegate next;
        int i = 0;

        public CounterMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, ICounter counter, CounterService counterService)
        {
            
           i++;
           context.Response.ContentType = "text/html; charset=utf-8";
           await context.Response.WriteAsync($"Запрос {i}; Counter: {counter.Value}; Service: {counterService.Value.Value}");
        }
    }
}
