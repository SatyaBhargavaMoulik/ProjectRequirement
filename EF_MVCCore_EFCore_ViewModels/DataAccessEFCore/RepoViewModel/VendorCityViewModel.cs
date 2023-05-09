using DataAccessEFCore.RepoModelsEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEFCore.RepoViewModel
{
    public class VendorCityViewModel
    {
       public List<VendorInformationEF> VendorVMInfo { get; set; }
       public List<CityDetail> CityVMInfo { get; set; }
    }
}
