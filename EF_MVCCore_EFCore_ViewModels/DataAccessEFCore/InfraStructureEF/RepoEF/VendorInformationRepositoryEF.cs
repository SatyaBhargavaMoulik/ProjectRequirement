using DataAccessEFCore.InfraStructureEF.AbstractEF;
using DataAccessEFCore.RepoModelsEF;
using DataAccessEFCore.RepoViewModel;
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

        public string InsertVendor(VendorInformationEF vndr)
        {
            string msg = string.Empty;

            try
            {
          
                _context.VendorDetailData.Add(vndr);
                _context.SaveChanges();                     // Committing to physical DB

                if(vndr.VID > 0)
                {
                    msg = "success";
                }
                else
                {
                    msg = "failed";
                }

            }
            catch (Exception ex)
            {
                msg = "exception";
            }


            return msg;
        }



        public VendorInformationEF GetVendorOnVID(int vid)
        {
            VendorInformationEF vndr = new VendorInformationEF();

            try
            {
                vndr = _context.VendorDetailData.FirstOrDefault(vv => vv.VID == vid);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }


            return vndr;
        }

        public string UpdateVendor(VendorInformationEF vndr)
        {
            string msg = string.Empty;

            try
            {
                VendorInformationEF vndr_old = _context.VendorDetailData.FirstOrDefault(vv => vv.VID == vndr.VID);
                if(vndr_old != null)
                {
                    vndr_old.VName = vndr.VName;
                    vndr_old.Address = vndr.Address;
                    _context.SaveChanges();

                    msg = "success";
                }
                else
                {
                    msg = "failed";
                }


            }
            catch (Exception ex)
            {
                msg = "exception";
            }


            return msg;
        }

        public string DeleteVendorONVendorID(int vid)
        {
            VendorInformationEF vndr_old = _context.VendorDetailData.FirstOrDefault(vv => vv.VID == vid);
            _context.VendorDetailData.Remove(vndr_old);
            _context.SaveChanges();

            return "success";
        }

        public List<VendorInformationEF> GetAllVendorsSpecificFields()
        {
            List<VendorInformationEF> lst = new List<VendorInformationEF>();

            try
            {
                lst = _context.VendorDetailData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }


            return lst;
        }

        public VendorCityViewModel GetVendorsAndCities()
        {
            VendorCityViewModel vm = new VendorCityViewModel();
            List<VendorInformationEF>  lstVendors = _context.VendorDetailData.ToList();
            List<CityDetail> lstCity = _context.CityDetailData.ToList();

            vm.VendorVMInfo = lstVendors;
            vm.CityVMInfo= lstCity;

            return vm;
        }
    }
}
