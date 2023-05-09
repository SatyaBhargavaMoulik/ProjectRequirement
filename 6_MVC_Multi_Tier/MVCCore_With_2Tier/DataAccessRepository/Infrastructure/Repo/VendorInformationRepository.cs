using DataAccessRepository.Infrastructure.Abstract;
using DataAccessRepository.RepoModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessRepository.Infrastructure.Repo
{
    public class VendorInformationRepository : IVendorInformationRepository
    {
        public List<VendorInformation> GetAllVendors()
        {
            List<VendorInformation> lstVendor = new List<VendorInformation>();
            string conString = "Server=DESKTOP-I3BL8NK\\LOCAL;Database=INVENTORY_MANAGEMENT;Integrated Security=true";
            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("GetVndorDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        VendorInformation vndr = new VendorInformation();
                        vndr.VID = Convert.ToInt32(dr["VID"]);
                        vndr.VName = dr["VName"].ToString();
                        lstVendor.Add(vndr);
                    }
                }


            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }

            return lstVendor;
        }
    }
}
