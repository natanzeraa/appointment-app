using AppointmentApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentApplication.Data
{
    public class AppDbContext : DbContext
    {
        public required DbSet<Employee> Employees { get; set; }
        public required DbSet<Costumer> Costumers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}