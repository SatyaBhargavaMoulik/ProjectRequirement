using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCCore_ModelAnnotations.Models
{
    public class UserDetail
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "USer ID is mandatory")]
        public string UserID { get; set; }

        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Invalid Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Range(18, 60, ErrorMessage = "Invalid age")]
        public int Age { get; set; }

        [StringLength(50, ErrorMessage = "Max no. of character should be 50")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Invalid Name")]
        public string Designation { get; set; }
    }
}
