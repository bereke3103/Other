WebApplicationBuilder builder = WebApplication.CreateBuilder();

WebApplication app = builder.Build();

app.Map("/home", appBuilder =>
{
    appBuilder.Map("/index", Index);
    appBuilder.Map("/about", About);

    appBuilder.Run(async (context) => await context.Response.WriteAsync("Home page"));
});

app.Run(async (context) => await context.Response.WriteAsync("Page not found"));

app.Run();

void Index(IApplicationBuilder build)
{
    build.Run(async context => await context.Response.WriteAsync("Index page"));
}

void About (IApplicationBuilder build)
{
    build.Run(async context => await context.Response.WriteAsync($"{nameof(About)}"));
}
