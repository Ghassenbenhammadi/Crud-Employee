using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-D2HJFH2; initial catalog=EmployeeDataBase; integrated security=SSPI;");
        }
    }
}
