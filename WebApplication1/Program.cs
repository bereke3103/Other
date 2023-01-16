using System.Text;
using WebApplication1.Middleware;
using WebApplication1.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder();
builder.Services.AddTransient<IHelloService, RuHelloService>();
builder.Services.AddTransient<IHelloService, EnHelloService>();

WebApplication app = builder.Build();

app.UseMiddleware<HelloMiddleware>();


app.Run();
