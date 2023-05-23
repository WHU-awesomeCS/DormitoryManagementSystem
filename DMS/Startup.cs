using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Principal;
using DMS.Data.Entities;
using System;

namespace DMS
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("ConnectionStrings");
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentId);

            modelBuilder.Entity<Dormitory>()
                .HasKey(d => d.DormitoryNumber);

            modelBuilder.Entity<Room>()
                .HasKey(r => r.RoomNumber);

            modelBuilder.Entity<Staff>()
                .HasKey(s => s.WorkId);

            modelBuilder.Entity<Teacher>()
                .HasKey(t => t.WorkId);

            modelBuilder.Entity<Account>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<RepairRequest>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Notification>()
                .HasKey(n => n.Id);

            modelBuilder.Entity<Visitor>()
                .HasKey(v => v.Id);

            modelBuilder.Entity<LeaveApplication>()
                .HasKey(l => l.Id);

            modelBuilder.Entity<Student>()
                .HasOne<Room>()
                .WithMany()
                .HasForeignKey(s => s.DormitoryNumber);

            modelBuilder.Entity<Room>()
                .HasOne<Dormitory>()
                .WithMany()
                .HasForeignKey(r => r.dormitory);

            modelBuilder.Entity<Staff>()
                .HasOne<Dormitory>()
                .WithMany()
                .HasForeignKey(s => s.DormitoryInCharge);

            modelBuilder.Entity<Teacher>()
                .HasOne<Dormitory>()
                .WithMany()
                .HasForeignKey(t => t.DormitoryInCharge);

            modelBuilder.Entity<RepairRequest>()
                .HasOne<Student>()
                .WithMany()
                .HasForeignKey(r => r.StudentId);

            modelBuilder.Entity<RepairRequest>()
                .HasOne<Room>()
                .WithMany()
                .HasForeignKey(r => r.RoomNumber);

            modelBuilder.Entity<Visitor>()
                .HasOne<Dormitory>()
                .WithMany()
                .HasForeignKey(v => v.DormitoryNumber);

            modelBuilder.Entity<LeaveApplication>()
                .HasOne<Student>()
                .WithMany()
                .HasForeignKey(l => l.StudentId);

            modelBuilder.Entity<LeaveApplication>()
                .HasOne<Teacher>()
                .WithMany()
                .HasForeignKey(l => l.Applicant);
        }

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
            services.AddDbContext<MyDbContext>(options =>
                options.UseMySQL("ConnectionStrings"));

            // 其他服务配置代码...
        }

        public void Configure()
        {
            // 配置其他中间件和路由...
        }
    }
}
