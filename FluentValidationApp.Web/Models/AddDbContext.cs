using Microsoft.EntityFrameworkCore;

namespace FluentValidationApp.Web.Models
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) 
        { 

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Adress> Addresses { get; set; }
    }
}
