using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Authentication_Authorization.Models
{
    [Table("UserDetails")]
    public class UserDetail
    {
        [Key]
        [Column(TypeName ="int")]
        public int ID { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string UserID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }
        [Column(TypeName = "int")]
        public int? DeptID { get; set; }
        [Column(TypeName = "int")]
        public int RoleID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string RoleDescr { get; set; }
    }
}
