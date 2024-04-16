using Microsoft.EntityFrameworkCore;
using MvcCrud.Models.Domain;

namespace MvcCrud.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
