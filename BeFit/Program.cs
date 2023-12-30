using BeFit.Application.CwiczenieApplication;
using BeFit.Application.CwiczenieApplication.CwiczenieApplication;
using BeFit.Application.SesjaTreningowaApplication;
using BeFit.Application.UzytkownicyApplication;
using BeFit.Infrastructure.CwiczenieRepositories;
using BeFit.Infrastructure.CwiczenieRepositories.Mapping;
using BeFit.Infrastructure.SesjaTreningowaRespositories;
using BeFit.Infrastructure.UzytkownicyRespositories;
using BeFit.Infrastructure.UzytkownicyRespositories.Mappig;
using BeFit.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BeFitDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(CwiczenieMappiingProfile));
builder.Services.AddAutoMapper(typeof(UzytkownicyMappingProfilecs));
builder.Services.AddScoped<ICwiczeniaApplication, CwiczeniaApplication>();
builder.Services.AddScoped<ICwiczenia, CwiczenieRepository>();
builder.Services.AddScoped<IUzytkownicyApplication, UzytkownicyApplication>();
builder.Services.AddScoped<IUzytkownicyRespositories, UzytkownicyRespositories>();
builder.Services.AddScoped<ISesjaTreningowaApplication, SesjaTreningowaApplication>();
builder.Services.AddScoped<ISesjaTreningowaRepository, SesjaTreningowaRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
