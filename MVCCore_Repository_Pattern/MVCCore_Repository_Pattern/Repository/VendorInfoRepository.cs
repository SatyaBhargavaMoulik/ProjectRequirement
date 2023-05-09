using MVCCore_Repository_Pattern.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MVCCore_Repository_Pattern.Repository
{
    public class VendorInfoRepository : IVendorInfoRepository
    {
        public List<Vendor> GetAllVendors()
        {
            List<Vendor> lstVendor = new List<Vendor>();
            string conString = "Server=DESKTOP-I3BL8NK\\LOCAL;Database=INVENTORY_MANAGEMENT;Integrated Security=true";
            try
            {
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("GetVndorDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Vendor vndr = new Vendor();
                        vndr.VID = Convert.ToInt32(dr["VID"]);
                        vndr.VName = dr["VName"].ToString();
                        lstVendor.Add(vndr);
                    }
                }


            }
            catch(Exception ex)
            {
                string err = ex.Message;
            }

            return lstVendor;
        }
    }
}
