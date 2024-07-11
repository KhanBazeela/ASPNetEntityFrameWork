using Microsoft.EntityFrameworkCore;
using WebApplication5.Entities;

namespace WebApplication5
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
