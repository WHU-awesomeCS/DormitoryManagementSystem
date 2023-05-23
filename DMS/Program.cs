using DMS;
using DMS.Data;
using DMS.Data.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


/*public class Program
{
     public static void Main(string[] args)
     {
         CreateHostBuilder(args).Build().Run();
     }

    // Test DB
    public static async Task Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        // 获取 AppDbContext 实例以执行测试
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var dbContext = services.GetRequiredService<MyDbContext>();

            try
            {
                await dbContext.Database.EnsureCreatedAsync(); // 确保数据库已创建

                // 添加测试代码
                var newAccount = new Account
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "john123",
                    Password = "password123",
                    UserRole = "User"
                };

                dbContext.Accounts.Add(newAccount);
                await dbContext.SaveChangesAsync();

                var account = await dbContext.Accounts.FirstOrDefaultAsync(a => a.Id == newAccount.Id);

                Console.WriteLine($"Id: {account.Id}");
                Console.WriteLine($"UserName: {account.UserName}");
                Console.WriteLine($"Password: {account.Password}");
                Console.WriteLine($"UserRole: {account.UserRole}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while testing the database connection: {ex.Message}");
            }
        }

        await host.RunAsync();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
       Host.CreateDefaultBuilder(args)
           .ConfigureWebHostDefaults(webBuilder =>
           {
               webBuilder.UseStartup<Startup>();
           });

}*/