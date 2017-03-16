using System.Data.Entity;

namespace Model
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Company> Companies { get; set; }
    }
}