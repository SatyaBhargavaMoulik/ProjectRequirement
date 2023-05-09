using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IRCTC_WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPNRStatusService" in both code and config file together.
    [ServiceContract]
    public interface IPNRStatusService
    {
        [OperationContract]
        void GetPNRStatus();
    }
}
