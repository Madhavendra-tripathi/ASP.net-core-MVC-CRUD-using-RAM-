using Microsoft.EntityFrameworkCore;

namespace CRUD_asp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } // This creates "Users" table
    }
}
