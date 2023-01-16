using WebApplication1.Middleware;
using WebApplication1.Service;
using WebApplication1.Service.Interface;

WebApplicationBuilder builder = WebApplication.CreateBuilder();
builder.Services.AddSingleton<ValueStorage>();
builder.Services.AddSingleton<IGenerator>(serv=> serv.GetRequiredService<ValueStorage>());
builder.Services.AddSingleton<IReader>(serv=> serv.GetRequiredService<ValueStorage>());

//builder.Services.AddSingleton<IGenerator, ValueStorage>();
//builder.Services.AddSingleton<IReader, ValueStorage>();

WebApplication app = builder.Build();

app.UseMiddleware<GeneratoMiddleware>();
app.UseMiddleware<ReaderMiddleware>();


app.Run();
