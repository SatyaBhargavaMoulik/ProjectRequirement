using Microsoft.EntityFrameworkCore;

namespace MVC_Authentication_Authorization.Models
{
    public class UserAuthConext : DbContext
    {
        public DbSet<UserDetail> UserDetails { get; set; }        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-I3BL8NK\\LOCAL;Database=AuthExample_July2022;Integrated Security=true;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
