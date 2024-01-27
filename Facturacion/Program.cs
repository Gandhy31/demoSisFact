using AutoMapper;
using Facturacion.Mapping;
using Facturacion.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

#region Cadenas de Conexión
string connSqlServer = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<SISTEMA_FACTURACIONContext>
    (
        dbContextOptions => dbContextOptions
            .UseSqlServer(connSqlServer)
    );
#endregion

#region Automapper

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new PerfilMappings());
});

IMapper mapper = mappingConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

#endregion

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
