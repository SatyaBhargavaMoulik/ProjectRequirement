using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DA_EFCore.Model
{
    public partial class Employee
    {
        [Key]
        [Column("EmpID")]
        public int EmpId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? EmpName { get; set; }
        public int? DeptId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salary { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? MobileNumber { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? EmailAddress { get; set; }
    }
}
