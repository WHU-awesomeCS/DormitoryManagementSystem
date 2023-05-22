using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Principal;
using DMS.Data.Entities;

namespace DMS
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        // 定义实体集和数据库表的映射关系    
        public DbSet<Student> Students { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }
    }
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("MySqlConnection");

            services.AddDbContext<MyDbContext>(options =>
                options.UseMySQL(connectionString));

            // 其他服务注册和配置...
        }

        public void Configure()
        {
            // 配置其他中间件和路由...
        }
    }
}
