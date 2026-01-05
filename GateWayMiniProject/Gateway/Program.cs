using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// پورت Gateway را 7000 می‌گذاریم
builder.WebHost.UseUrls("http://localhost:7000");

// خواندن تنظیمات Ocelot
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// سرویس‌های Ocelot
builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

// یک روت ساده برای تست خود Gateway
app.MapGet("/", () => "Gateway is up. Try GET /api/ping");

// Ocelot باید قبل از Run فعال شود
await app.UseOcelot();

app.Run();
