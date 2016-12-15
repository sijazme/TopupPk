using Microsoft.EntityFrameworkCore;

namespace TopupPk.Models
{
    public class TopupPkContext : DbContext
    {
        public TopupPkContext(DbContextOptions<TopupPkContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
    }
}
