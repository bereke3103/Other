WebApplicationBuilder builder = WebApplication.CreateBuilder();

WebApplication app = builder.Build();

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    if (context.Request.Path == "/upload" && context.Request.Method == "POST")
    {
        IFormFileCollection files = context.Request.Form.Files;

        //путь к папке, где будут храниться файлы
        var uploadPath = $"{Directory.GetCurrentDirectory()}/uploads";
        Directory.CreateDirectory(uploadPath);

        foreach (var file in files)
        {
            // путь к папке uploads
            string fullPath = $"{uploadPath}/{file.FileName}";

            // сохраняем файл в папку uploads
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
        }
        await context.Response.WriteAsync("Файлы успешно загружены");
    } else
    {
        await context.Response.SendFileAsync("html/htmlpage.html");
    }
});

app.Run();