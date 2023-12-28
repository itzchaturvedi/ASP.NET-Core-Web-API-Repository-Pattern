
using Repository_Pattern.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository_Pattern.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Owner>? Owners { get; set; }
        public DbSet<Account>? Accounts { get; set; }
    }
}