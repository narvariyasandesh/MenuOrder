using Microsoft.EntityFrameworkCore;

namespace MenuOrder.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<MenuList> MenuList { get; set; }
    }
}
