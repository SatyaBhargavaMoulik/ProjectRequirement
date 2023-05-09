using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAProductDetail.RepoModel
{
    public class ProdContext : DbContext
    {
        public DbSet<Product> ProductsInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-I3BL8NK\\LOCAL;Database=MyAPIProductInfo;Integrated Security=true;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
