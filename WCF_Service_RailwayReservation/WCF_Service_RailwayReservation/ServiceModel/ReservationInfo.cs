using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_Service_RailwayReservation.ServiceModel
{
    [DataContract]
    public class ReservationInfo
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string PNRNumber { get; set; }
        [DataMember]
        public string PNRStatus { get; set; }
        [DataMember]
        public DateTime TravelDate { get; set; }
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public string SuccessMessage { get; set; }

    }
}