using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zteam.Models;

namespace Zteam.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Game> Game { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<BuyDtl> BuyDtls { get; set; }
        public DbSet<Buying> Buyings { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDtl> CartDtls { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }

}
