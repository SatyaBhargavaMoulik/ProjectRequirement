using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCore_EF_LazyLoad.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        [ForeignKey("DepartmentInfo")]
        public int DeptID { get; set; }
        public virtual Department DepartmentInfo { get; set; }

    }
}
