using DatabaseProblems.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProblems.Data
{
    public class TempDbContext : DbContext
    {
        public TempDbContext(DbContextOptions<TempDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; } = null!;
    }
}
