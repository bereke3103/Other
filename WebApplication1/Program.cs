WebApplicationBuilder builder = WebApplication.CreateBuilder();

WebApplication app = builder.Build();



app.UseWhen(context => context.Request.Path == "/time",
    appBuilder =>
    {
        appBuilder.Use(async (context, next) =>
        {
            var time = DateTime.Now.ToShortDateString();
            Console.WriteLine($"Time: {time}");
            await next();
        });

        appBuilder.Run(async context =>
        {
            var time = DateTime.Now.ToShortTimeString();
            await context.Response.WriteAsync($"Time: {time}");
        });

    });

app.Run(async context =>
{
    await context.Response.WriteAsync("HELLO METANIT COM");
});

app.Run();