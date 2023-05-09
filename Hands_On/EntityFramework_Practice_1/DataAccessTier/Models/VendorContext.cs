using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessTier.Models
{
    public class VendorContext:DbContext
    {
        public DbSet<Vendor> VendorsDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Server=MOULIK;Database=Practice_Task_2;Integrated Security=true;Encrypt=false");
            }
            base.OnConfiguring(optionBuilder);
        }
        
    }
}
