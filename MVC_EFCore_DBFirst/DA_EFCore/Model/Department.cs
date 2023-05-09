using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DA_EFCore.Model
{
    public partial class Department
    {
        [Key]
        public int DeptId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? DeptName { get; set; }
    }
}
