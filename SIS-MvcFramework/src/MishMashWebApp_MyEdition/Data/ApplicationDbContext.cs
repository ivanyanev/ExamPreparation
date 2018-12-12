using Microsoft.EntityFrameworkCore;
using MishMashWebApp_MyEdition.Model;

namespace MishMashWebApp_MyEdition.Data
{
    public class ApplicationDbContext : DbContext
    {
        public  ApplicationDbContext()
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Channel> Channels { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<UsersChannels> UsersChannels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MishMash;Integrated Security=True;");
        }
    }
}
