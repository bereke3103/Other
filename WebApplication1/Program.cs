using WebApplication1;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

WebApplication app = builder.Build();

app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<AuthenticationMiddleware>();
app.UseMiddleware<RoutingMiddleware>();


app.Run();
