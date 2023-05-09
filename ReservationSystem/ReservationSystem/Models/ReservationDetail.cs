namespace ReservationSystem.Models
{
    public class ReservationDetail
    {
        public int ID { get; set; }
        public string PNRNumber { get; set; }
        public string PNRStatus { get; set; }
        public DateTime TravelDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public ReservationDetail GetReservationStatus(string pnr)
        {
            List<ReservationDetail> lstData = new List<ReservationDetail>
            {
                new ReservationDetail{ ID=1, PNRNumber="P111", PNRStatus="Conf", CreatedDate=DateTime.Now, TravelDate=DateTime.Now },
                new ReservationDetail{ ID=2, PNRNumber="P222", PNRStatus="WL", CreatedDate=DateTime.Now, TravelDate=DateTime.Now },
                new ReservationDetail{ ID=3, PNRNumber="P333", PNRStatus="WL", CreatedDate=DateTime.Now, TravelDate=DateTime.Now }
            };

            ReservationDetail response = new ReservationDetail();
            response = lstData.FirstOrDefault(x => x.PNRNumber.Equals(pnr));

            return response;
        }
    }
}
