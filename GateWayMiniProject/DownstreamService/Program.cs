var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// پورت را ثابت 7001 می‌گذاریم تا راحت تست کنیم
app.Urls.Add("http://localhost:7001");

// 1) تست سلامت/پینگ
app.MapGet("/ping", () => Results.Ok(new { ok = true, service = "downstream", time = DateTime.UtcNow }));

// 2) اکو: هر مسیر و کوئری و هدر را برمی‌گرداند تا ببینیم چی بهش رسیده
app.Map("/{**catchall}", (HttpContext ctx) =>
{
    var path = ctx.Request.Path + ctx.Request.QueryString;
    var headers = ctx.Request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString());
    return Results.Ok(new
    {
        message = "Downstream received your request",
        method = ctx.Request.Method,
        path,
        headers
    });
});

app.Run();
