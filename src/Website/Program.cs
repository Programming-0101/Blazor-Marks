using Microsoft.EntityFrameworkCore;
using WebApp.Components;
using WebApp.Data.BLL;
using WebApp.Data.DAL;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MyDb");

// Add services to the container.
builder.Services.AddDbContext<MyMarksContext>(options => options.UseSqlite(connectionString));
builder.Services.AddTransient<CourseServices>(options => new CourseServices(options.GetRequiredService<MyMarksContext>()));
builder.Services.AddTransient<GradingServices>(options => new GradingServices(options.GetRequiredService<MyMarksContext>()));
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
