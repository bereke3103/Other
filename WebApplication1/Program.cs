using Microsoft.Extensions.FileProviders;
using WebApplication1.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

builder.Configuration.AddInMemoryCollection(new Dictionary<string, string>
{
    {"name", "Bereke"},
    {"age", "30"}

});

WebApplication app = builder.Build();

//2 вариант
app.Map("/", (IConfiguration configuration) => $"{configuration["name"]} - {configuration["age"]}");

//1 вариант
//app.Run(async (context) =>
//{
//    string name = app.Configuration["name"];
//    string age = app.Configuration["age"];
//    await context.Response.WriteAsync($"{name} - {age}");
//});




app.Run();
