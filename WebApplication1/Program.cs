using System.Text;
using WebApplication1.Middleware;
using WebApplication1.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

builder.Services.AddTransient<TimeService>();

WebApplication app = builder.Build();

app.UseMiddleware<TimerMiddleware>();
app.Run(async (context) =>
{
    //context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("Hello metanit");
});




app.Run();
