using DataAccessTier.Infrastructure.Abstraction;
using DataAccessTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier.Infrastructure.Repositary
{
    public class VendorRepositary : IVendorRepositary
    {
        VendorContext obj_vendorContext = new VendorContext();
        public List<Vendor> GetAllVendorDetails()
        {
            List<Vendor> vendorsList = new List<Vendor>();
            try
            {
                vendorsList = obj_vendorContext.VendorsDetails.ToList();
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }
            return vendorsList;
        }
    }
}
