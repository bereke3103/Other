using System.Text;
using WebApplication1.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

//IServiceCollection services = builder.Services;
builder.Services.AddTimeServices();

WebApplication app = builder.Build();

app.Run(async context =>
{
    var timeService = app.Services.GetService<TimeService>();
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
});



app.Run();
