﻿namespace MVCCore_Repository_Pattern.Models
{
    public class Vendor
    {
        public int VID { get; set; }
        public string VName { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
