using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineFastFoodEntityLayer.Concrete;

namespace OnlineFastFood_DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=DESKTOP-57R498V\\SQLEXPRESS01;database=OnlineFastFoodDb; integrated security=true; TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }


        // DbSets
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet <AppRole> AppRoles { get; set; } // normaly don't need to add AppRole and AppUser because they already inherited Identity , but We have relationships with tables , therefore I added.
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
    }
}
