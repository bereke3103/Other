namespace WebApplication1
{
    public class ErrorHandlingMiddleware
    {
        readonly RequestDelegate Next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await Next.Invoke(context);
            if(context.Response.StatusCode == 403)
            {
                await context.Response.WriteAsync("ACCESS DENIED");
            }
            else if (context.Response.StatusCode == 404)
            {
                await context.Response.WriteAsync("Not afound");
            }
        }
    }
}
