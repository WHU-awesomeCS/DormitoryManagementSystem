using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Principal;
using DMS.Data.Entities;
using DMS.util;
using System;
using DMS.Controllers;

namespace DMS
{
   
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
       

            var mysqlconnection = Configuration.Get<AppConfiguration>().MySqlConnection; 
            services.AddDbContextPool<MyDbContext>(options => options.UseMySql(mysqlconnection, new MySqlServerVersion(new Version(8, 0, 33))));

            services.AddScoped<HomeController>();
        }

        public void Configure()
        {
            // 配置其他中间件和路由...
        }
    }
}
