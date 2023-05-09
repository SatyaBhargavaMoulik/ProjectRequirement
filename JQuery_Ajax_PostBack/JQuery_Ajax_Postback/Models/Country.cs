using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JQuery_Ajax_Postback.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public List<Country> GetCountries()
        {
            List<Country> lstCountry = new List<Country>
            {
                new Country{ CountryId=0, CountryName="Select"},
                new Country{ CountryId=1, CountryName="India"},
                new Country{ CountryId=2, CountryName="China"},
                new Country{ CountryId=3, CountryName="Australia"},
                new Country{ CountryId=4, CountryName="South Africa"}
            };

            return lstCountry;
        }

        public List<SelectListItem> GetStates(string id)
        {
            List<SelectListItem> states = new List<SelectListItem>();
            switch (id)
            {
                case "1":
                    states.Add(new SelectListItem() { Text = "Select", Value = "0" });
                    states.Add(new SelectListItem() { Text = "Andhra Pradesh", Value = "1" });
                    states.Add(new SelectListItem() { Text = "Karnataka", Value = "2" });
                    states.Add(new SelectListItem() { Text = "Maharashtra", Value = "3" });
                    states.Add(new SelectListItem() { Text = "Tamilnadu", Value = "4" });
                    break;
                case "2":
                    states.Add(new SelectListItem() { Text = "Select", Value = "0" });
                    states.Add(new SelectListItem() { Text = "Ch1", Value = "1" });
                    states.Add(new SelectListItem() { Text = "Ch2", Value = "2" });
                    states.Add(new SelectListItem() { Text = "Ch3", Value = "3" });
                    states.Add(new SelectListItem() { Text = "Ch4", Value = "4" });
                    break;
                default: break;
            }
            return states;
        } 
    }
}
