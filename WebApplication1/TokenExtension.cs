namespace WebApplication1
{
    
    public static class TokenExtension
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder app, string pattern)
        {
            return app.UseMiddleware<TokenMiddleware>(pattern);
        }
    }
}
