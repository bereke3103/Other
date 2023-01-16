using System.Text;
using WebApplication1;
using WebApplication1.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

builder.Services.AddTransient<ICounter, RandomCounter>();
builder.Services.AddTransient<CounterService>();

WebApplication app = builder.Build();

app.UseMiddleware<CounterMiddleware>();




app.Run();
