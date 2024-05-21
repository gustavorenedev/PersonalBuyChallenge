using Microsoft.EntityFrameworkCore;
using PersonalBuy.Data;

var builder = WebApplication.CreateBuilder(args);

// Adicione os serviços ao contêiner.
builder.Services.AddControllersWithViews();

// Configure o DbContext
builder.Services.AddDbContext<DataContext>(o =>
{
    o.UseOracle(builder.Configuration.GetConnectionString("OracleConnection"));
});

var app = builder.Build();

// Configure o pipeline de requisição HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cliente}/{action=Login}/{id?}");

app.Run();
