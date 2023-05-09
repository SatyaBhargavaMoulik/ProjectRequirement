using DataAccessRepository.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessRepository.Infrastructure.Abstract
{
    public interface IVendorInformationRepository
    {
        List<VendorInformation> GetAllVendors();
    }
}
