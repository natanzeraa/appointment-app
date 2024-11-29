using AppointmentApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentApplication.Data
{
    public class AppDbContext : DbContext
    {
        public required DbSet<Employee> Employees { get; set; }
        public required DbSet<Costumer> Costumers { get; set; }
        public required DbSet<Service> Services { get; set; }
        public required DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Appointments)
                .HasForeignKey(a => a.EmployeeId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Costumer)
                .WithMany()
                .HasForeignKey(a => a.CostumerId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Service)
                .WithMany()
                .HasForeignKey(a => a.ServiceId);

            base.OnModelCreating(modelBuilder);
        }
    }
}