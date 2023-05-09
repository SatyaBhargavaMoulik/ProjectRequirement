using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessRepository.RepoModels
{
    public class VendorInformation
    {
        public int VID { get; set; }
        public string VName { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
