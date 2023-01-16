using WebApplication1.Service;

namespace WebApplication1.Middleware
{
    public class HelloMiddleware
    {
        readonly IEnumerable<IHelloService> helloServices;

        public HelloMiddleware(RequestDelegate _, IEnumerable<IHelloService> helloServices)
        {
            this.helloServices = helloServices;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            httpContext.Response.ContentType = "text/html; charset=utf-8";
            string responseText = "";
            foreach (var service in helloServices)
            {
                responseText += $"<h3>{service.Message}</h3>";
            }

            await httpContext.Response.WriteAsync(responseText);
        }
        
    }
}
