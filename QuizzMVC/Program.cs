var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();
