using Microsoft.EntityFrameworkCore;

namespace Money_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
