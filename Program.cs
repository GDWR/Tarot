using Tarot.Components;
using Tarot.Services.TarotFactory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddSingleton<ITarotFactory, RandomChoiceTarotFactory>()
    .AddRazorComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

await app.RunAsync();