using CounterApp.Components;
using OpenAI;
using System.ClientModel;

DotNetEnv.Env.Load();
DotNetEnv.Env.Load("Counter/.env");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton(_ => new OpenAIClient(
    new ApiKeyCredential(Environment.GetEnvironmentVariable("AZURE_OPENAI_KEY") ?? "dummy"),
    new OpenAIClientOptions { Endpoint = new Uri(Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT") ?? "https://example.com/") })
    .GetChatClient(Environment.GetEnvironmentVariable("AZURE_OPENAI_MODEL") ?? "dummy"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
