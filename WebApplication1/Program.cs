using System.Text;
using WebApplication1.Middleware;
using WebApplication1.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

//IServiceCollection services = builder.Services;
builder.Services.AddTransient<ITimeService, ShortTimeService>();

WebApplication app = builder.Build();

app.UseMiddleware<TimeMessageMiddleware>();

//app.Run(async context =>
//{
//    var timeService = app.Services.GetService<TimeService>();
//    context.Response.ContentType = "text/html; charset=utf-8";
//    await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
//});



app.Run();
