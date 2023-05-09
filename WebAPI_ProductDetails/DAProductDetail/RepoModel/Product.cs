using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAProductDetail.RepoModel
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [Column(TypeName ="int")]
        public int ProductId { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }


    }
}
