using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEFCore.RepoModelsEF
{
    [Table("CityDetails")]
    public class CityDetail
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int? RegionID { get; set; }
    }
}
