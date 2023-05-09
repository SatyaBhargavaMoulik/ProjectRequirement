using Microsoft.EntityFrameworkCore;

namespace MVCCore_EF_LazyLoad.Models
{
    public class EmpContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-I3BL8NK\\LOCAL;Database=LazyLoadingDB;Integrated Security=true;").UseLazyLoadingProxies();
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
