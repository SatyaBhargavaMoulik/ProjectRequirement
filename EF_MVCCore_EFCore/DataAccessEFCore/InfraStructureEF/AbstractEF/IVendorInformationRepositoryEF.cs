using DataAccessEFCore.RepoModelsEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEFCore.InfraStructureEF.AbstractEF
{
    public interface IVendorInformationRepositoryEF
    {
        List<VendorInformationEF> GetAllVendors();
    }
}
