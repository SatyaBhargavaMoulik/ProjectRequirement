using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCF_Consume_ASPNET.MyService;

namespace WCF_Consume_ASPNET
{
    public partial class ResStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PNRStatusServiceClient objProxy = new PNRStatusServiceClient();
            string pnr = string.Empty;
            if(txtPNRNumber.Text.Trim().Length>0)
            {
                pnr = txtPNRNumber.Text.Trim();
                ReservationInfo objData = objProxy.GetPNRStatus(pnr);
                if(objData != null && objData.SuccessMessage.Equals("success"))
                {
                    lblMsg.Text = "Your PNR Number is " + objData.PNRNumber + " and status is " + objData.PNRStatus;
                }

            }
            else
            {
                lblMsg.Text = "PNR number should not be blank";
            }

           
        }
    }
}