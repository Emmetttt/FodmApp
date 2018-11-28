using Microsoft.EntityFrameworkCore;

namespace FodmApp.Models
{
    public class FodmAppContext : DbContext
    {
        public FodmAppContext(DbContextOptions<FodmAppContext> option) : base(option)
        {

        }

        public DbSet<Food> Foods { get; set; }
    }
}
