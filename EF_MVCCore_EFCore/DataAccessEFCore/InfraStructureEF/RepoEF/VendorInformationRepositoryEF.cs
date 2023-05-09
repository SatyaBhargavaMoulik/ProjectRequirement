using DataAccessEFCore.InfraStructureEF.AbstractEF;
using DataAccessEFCore.RepoModelsEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEFCore.InfraStructureEF.RepoEF
{
    public class VendorInformationRepositoryEF : IVendorInformationRepositoryEF
    {
        VendorManagementContext _context = new VendorManagementContext();
        public List<VendorInformationEF> GetAllVendors()
        {
            List<VendorInformationEF> lst = new List<VendorInformationEF>();

            try
            {
                lst = _context.VendorDetailData.ToList();
            }
            catch(Exception ex)
            {
                string str = ex.Message;
            }


            return lst;
        }
    }
}
