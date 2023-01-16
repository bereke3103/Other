WebApplicationBuilder builder = WebApplication.CreateBuilder();

WebApplication app = builder.Build();

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    if (context.Request.Path == "/upload" && context.Request.Method == "POST")
    {
        IFormFileCollection files = context.Request.Form.Files;

        //���� � �����, ��� ����� ��������� �����
        var uploadPath = $"{Directory.GetCurrentDirectory()}/uploads";
        Directory.CreateDirectory(uploadPath);

        foreach (var file in files)
        {
            // ���� � ����� uploads
            string fullPath = $"{uploadPath}/{file.FileName}";

            // ��������� ���� � ����� uploads
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
        }
        await context.Response.WriteAsync("����� ������� ���������");
    } else
    {
        await context.Response.SendFileAsync("html/htmlpage.html");
    }
});

app.Run();