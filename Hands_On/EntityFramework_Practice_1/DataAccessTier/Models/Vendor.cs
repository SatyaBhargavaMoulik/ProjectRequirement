using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessTier.Models
{
    [Table("Vendors")]
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
