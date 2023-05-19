using NewCIPlatform.Entities.Data;
using NewCIPlatform.Entities.Models;
using NewCIPlatform.Repository.Interface;
using NewCIPlatform.Repository.Repository;
using NewCIPlatform.Services.Service;
using NewCIPlatform.Services.ServiceInterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbCipContext>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();

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
    pattern: "{controller=Skill}/{action=MissionSkills}/{id?}");

app.Run();
