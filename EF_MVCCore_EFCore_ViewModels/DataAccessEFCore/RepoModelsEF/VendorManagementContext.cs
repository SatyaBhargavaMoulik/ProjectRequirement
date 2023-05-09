using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEFCore.RepoModelsEF
{
    public class VendorManagementContext : DbContext
    {
        public DbSet<VendorInformationEF> VendorDetailData { get; set; }
        public DbSet<CityDetail> CityDetailData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-I3BL8NK\\LOCAL;Database=MyVendorInfo;Integrated Security=true;");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
