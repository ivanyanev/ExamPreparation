using ChushkaWebApp_MyEdition.Models;
using Microsoft.EntityFrameworkCore;

namespace ChushkaWebApp_MyEdition.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ChushkaMyEdittion;Integrated Security=True;");
        }
    }
}
