using System.Text;
using WebApplication1.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

//IServiceCollection services = builder.Services;
builder.Services.AddTransient<ITimeService, ShortTimeService>();

WebApplication app = builder.Build();

app.Run(async context =>
{
    var timeService = app.Services.GetService<ITimeService>();
    await context.Response.WriteAsync($"Time: {timeService?.GetTtime()}");
});



app.Run();
