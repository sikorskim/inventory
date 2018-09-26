using Microsoft.EntityFrameworkCore;
using inventory;

namespace inventory
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Initial Catalog=inventory;User ID=root;Password=K^m!en649");
        }
    }
}
