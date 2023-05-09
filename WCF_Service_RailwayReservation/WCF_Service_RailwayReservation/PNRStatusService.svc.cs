using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Service_RailwayReservation.ServiceModel;

namespace WCF_Service_RailwayReservation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PNRStatusService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PNRStatusService.svc or PNRStatusService.svc.cs at the Solution Explorer and start debugging.
    public class PNRStatusService : IPNRStatusService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conString"]);
        public ReservationInfo GetPNRStatus(string pnr)
        {
            ReservationInfo resp = new ReservationInfo();

            SqlCommand com = new SqlCommand("GetPNRStatus", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@PNRNumber", pnr);

            DataTable dtData = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dtData);


                if (dtData.Rows.Count == 1)
                {
                    resp.ID = Convert.ToInt32(dtData.Rows[0]["ID"]);
                    resp.PNRStatus = dtData.Rows[0]["PNRStatus"].ToString();
                    resp.PNRNumber = dtData.Rows[0]["PNRNumber"].ToString();
                    resp.SuccessMessage = "success";
                    resp.TravelDate = Convert.ToDateTime(dtData.Rows[0]["TravelDate"]);
                    resp.CreatedDate = Convert.ToDateTime(dtData.Rows[0]["CreatedDate"]);
                }
                else
                {
                    resp.SuccessMessage = "Invalid operation";
                }

            }
            catch (Exception ex)
            {
                resp.SuccessMessage = "Some Exception";
            }

            return resp;
        }
    }
}
