using MVCCore_Repository_Pattern.Models;

namespace MVCCore_Repository_Pattern.Repository
{
    public interface IVendorInfoRepository
    {
        List<Vendor> GetAllVendors();
    }
}
