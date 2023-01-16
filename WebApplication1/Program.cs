using WebApplication1.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

builder.Services.Configure<RouteOptions>(option =>
{
    option.ConstraintMap.Add("secretcode", typeof(SecretCodeConstraint));
});

WebApplication app = builder.Build();

app.Map("/users/{name}/{token:secretcode(1234566)}/", (string name, int token) =>
{
    return $"Name: {name} \nToken: {token}";
});

app.Map("/", () => "Index page");





app.Run();
